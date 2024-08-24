using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MP4_To_MP3_Converter
{
    /// <summary>
    /// Provides methods for converting MP4 files to MP3/WAV files
    /// </summary>
    internal static class Converter
    {
        /// <summary>
        /// Converts MP4 file to MP3 file
        /// </summary>
        /// <param name="mp4FilePath"></param>
        /// <param name="mp3FilePath"></param>
        public static void MP4ToMP3(string mp4FilePath, string mp3FilePath)
        {
            using (MediaFoundationReader reader = new MediaFoundationReader(mp4FilePath))
            {
                WaveFileWriter.CreateWaveFile(mp3FilePath, reader);
            }
        }

        /// <summary>
        /// Converts MP4 file to WAV file
        /// </summary>
        /// <param name="mp4FilePath"></param>
        /// <param name="wavFilePath"></param>
        public static void MP4ToWav(string mp4FilePath, string wavFilePath)
        {
            MediaFoundationReader reader = new MediaFoundationReader(mp4FilePath);
            WaveStream waveStream = WaveFormatConversionStream.CreatePcmStream(reader);
            WaveFileWriter.CreateWaveFile(wavFilePath, waveStream);
            reader.Dispose();
        }
    }
}