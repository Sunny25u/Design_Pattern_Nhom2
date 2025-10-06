using System;
using System;

// Các subsystem phức tạp
class AudioPlayer
{
    public void PlayAudio() => Console.WriteLine("Phát âm thanh");
}

class VideoPlayer
{
    public void PlayVideo() => Console.WriteLine("Phát video");
}

class SubtitleManager
{
    public void LoadSubtitle() => Console.WriteLine("Tải phụ đề");
    public void DisplaySubtitle() => Console.WriteLine("Hiển thị phụ đề");
}

// Facade cung cấp giao diện đơn giản cho client
class MediaFacade
{
    private AudioPlayer audio;
    private VideoPlayer video;
    private SubtitleManager subtitle;

    public MediaFacade()
    {
        audio = new AudioPlayer();
        video = new VideoPlayer();
        subtitle = new SubtitleManager();
    }

    // Phát video đơn giản với phụ đề và âm thanh
    public void PlayVideoWithSubtitle()
    {
        video.PlayVideo();
        audio.PlayAudio();
        subtitle.LoadSubtitle();
        subtitle.DisplaySubtitle();
    }
}

// Client sử dụng Facade
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MediaFacade mediaFacade = new MediaFacade();

        mediaFacade.PlayVideoWithSubtitle();

        // Client không phải gọi riêng lẻ các subsystem
    }
}
