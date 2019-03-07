using UnityEngine;

namespace SFramework
{
    public class AudioManager : MonoSingleton<AudioManager>
    {
        private AudioListener mAudioListener;
        private AudioSource mMusicSource;

        private void CheckAudioListener()
        {
            if (!mAudioListener)
            {
                mAudioListener = FindObjectOfType<AudioListener>();
            }

            if (!mAudioListener)
            {
                mAudioListener = gameObject.AddComponent<AudioListener>();
            }
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        public void PlaySound(string soundName)
        {
            CheckAudioListener();

            var coinSound = Resources.Load<AudioClip>(soundName);
            var audioSource = gameObject.AddComponent<AudioSource>();         
            audioSource.clip = coinSound;
            audioSource.Play();
        }

        /// <summary>
        /// 播放背景音乐
        /// </summary>
        public void PlayMusic(string musicName, bool loop)
        {
            CheckAudioListener();

            if (!mMusicSource)
            {
                mMusicSource = gameObject.AddComponent<AudioSource>();
            }

            var coinSound = Resources.Load<AudioClip>(musicName);

            mMusicSource.clip = coinSound;
            mMusicSource.loop = loop;
            mMusicSource.Play();
        }

        /// <summary>
        /// 停止播放背景音乐
        /// </summary>
        public void StopMusic()
        {
            mMusicSource.Stop();
        }

        /// <summary>
        /// 暂停播放背景音乐
        /// </summary>
        public void PauseMusic()
        {
            mMusicSource.Pause();
        }

        /// <summary>
        /// 继续播放背景音乐
        /// </summary>
        public void ResumeMusic()
        {
            mMusicSource.UnPause();
        }

        public void MusicOff()
        {
            mMusicSource.Pause();
            mMusicSource.mute = true;
        }

        public void SoundOff()
        {
            var audioSources = GetComponents<AudioSource>();
            foreach (var audioSource in audioSources)
            {
                if(audioSource != mMusicSource)
                {
                    audioSource.Pause();
                    audioSource.mute = true;
                }
            }
        }

        public void MusicOn()
        {
            mMusicSource.UnPause();
            mMusicSource.mute = false;
        }

        public void SoundOn()
        {
            var audioSources = GetComponents<AudioSource>();
            foreach (var audioSource in audioSources)
            {
                if(audioSource != mMusicSource)
                {
                    audioSource.UnPause();
                    audioSource.mute = false;
                }
            }
        }
    }
}

