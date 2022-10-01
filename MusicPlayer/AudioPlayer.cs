interface IAudioPlayer {
    void Play();
    void Pause();
    void Stop();
}

interface IMusic {
    void MusicName();
    void Melody();
}

class AudioPlayer: IAudioPlayer, IMusic {

    public void Play() {
        Console.WriteLine("Play");
    }

    public void Pause() {
        Console.WriteLine("Pause");
    }

    public void Stop() {
        Console.WriteLine("Stop");
    }

    public void MusicName() {
        Console.WriteLine("8 years");
    }

    public void Melody() {
        Console.WriteLine("Tuu Tuu");
    }
}