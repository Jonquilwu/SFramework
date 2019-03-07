using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SFramework
{
    public abstract partial class MonoBehaviourSimplify : MonoBehaviour
    {
        #region Timer
        public void Delay(float seconds, Action onFinished)
        {
            StartCoroutine(DelayCoroutine(seconds, onFinished));
        }

        private static IEnumerator DelayCoroutine(float seconds, Action onFinished)
        {
            yield return new WaitForSeconds(seconds);
            onFinished();
        }
        #endregion

        #region MsgDispatcher
        List<MsgRecord> mMsgRecorder = new List<MsgRecord>();

        private class MsgRecord
        {
            private MsgRecord() { }

            static Stack<MsgRecord> mMsgRecordPool = new Stack<MsgRecord>();

            public static MsgRecord Allocate(string msgName, Action<object> onMsgReceived)
            {
      
                var retRecord = mMsgRecordPool.Count > 0 ? mMsgRecordPool.Pop() : new MsgRecord();

                retRecord.Name = msgName;
                retRecord.OnMsgReceived = onMsgReceived;

                return retRecord;
            }

            public void Recycle()
            {
                Name = null;
                OnMsgReceived = null;
                mMsgRecordPool.Push(this);
            }

            public string Name;
            public Action<object> OnMsgReceived;
        }

        public void RegisterMsg(string msgName, Action<object> onMsgReceived)
        {
            MsgDispatcher.Register(msgName, onMsgReceived);

            mMsgRecorder.Add(MsgRecord.Allocate(msgName, onMsgReceived));
        }
        protected void UnRegisterMsg(string msgName)
        {
            var selectRecords = mMsgRecorder.FindAll(recorder => recorder.Name == msgName);

            selectRecords.ForEach(record =>
            {
                MsgDispatcher.UnRegister(record.Name, record.OnMsgReceived);
                mMsgRecorder.Remove(record);
            });

            selectRecords.Clear();
        }

        protected void UnRegisterMsg(string msgName, Action<object> onMsgReceived)
        {
            var selectedRecords = mMsgRecorder.FindAll(recorder =>recorder.Name == msgName && recorder.OnMsgReceived ==onMsgReceived);
            selectedRecords.ForEach(record =>
            {
            MsgDispatcher.UnRegister(record.Name,
            record.OnMsgReceived);
                mMsgRecorder.Remove(record);
            });
            selectedRecords.Clear();
        }

        protected void SendMsg(string msgName, object data)
        {
            MsgDispatcher.Send(msgName, data);
        }

        private void OnDestroy()
        {
            OnBeforeDestroy();
            foreach (var msgRecord in mMsgRecorder)
            {
                MsgDispatcher.UnRegister(msgRecord.Name, msgRecord.OnMsgReceived);
                msgRecord.Recycle();
            }
            mMsgRecorder.Clear();
        }

        protected abstract void OnBeforeDestroy();
        #endregion
    }
}

