using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundApp.Model
{
    public class MusicManager
    {
        public static List<Music> getMusic()
        {
            var sounds = new List<Music>();

            sounds.Add(new Music("Hai Triệu Năm", MusicCategory.Den, "Assets/Music/2trieunam.mp3", "Assets/Img/2trieunam.png"));
            sounds.Add(new Music("Bài này chill phết", MusicCategory.Den, "Assets/Music/bainaychillphet.mp3", "Assets/Img/bainaychill.jpg"));
            sounds.Add(new Music("Suýt nữa thì", MusicCategory.Andiez, "Assets/Music/suytnuathi.mp3", "Assets/Img/suytnuathi.jpg"));
            sounds.Add(new Music("Độ tộc 2 ", MusicCategory.Mixi, "Assets/Music/DoToc2.mp3", "Assets/Img/dôtc2.jfif"));
            sounds.Add(new Music("Hương ", MusicCategory.Mixi, "Assets/Music/huong.mp3", "Assets/Img/.jpg"));
            sounds.Add(new Music("3710-3 ", MusicCategory.Nau, "Assets/Music/31073.mp3", "Assets/Img/3170-3.jfif"));
            sounds.Add(new Music("Cưới thôi ", MusicCategory.Masew, "Assets/Music/CuoiThoi.mp3", "Assets/Img/aino.jpg"));
            sounds.Add(new Music("Ái nộ  ", MusicCategory.Masew, "Assets/Music/AiNo.mp3", "Assets/Img/aino.jpg"));
            
            return sounds;
        }

        public static void GetAllMusic(ObservableCollection<Music> music)
        {
            var allSounds = getMusic();
            music.Clear();
            allSounds.ForEach(p => music.Add(p));
        }

        public static void GetMusicByCategory(ObservableCollection<Music> sounds, MusicCategory musicCategory)
        {
            var allMusic = getMusic();
            var filteredMusic = allMusic.Where(p => p.Category == musicCategory).ToList();
            sounds.Clear();
            filteredMusic.ForEach(p => sounds.Add(p));
        }

        public static void GetMusicByName(ObservableCollection<Music> sounds, string name)
        {
            var allMusic = getMusic();
            var filteredSounds = allMusic.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}
