using Omny.Models;
using System.Threading.Tasks;

namespace Omny
{
    public interface IOmnyClient
    {
        Task<Clips> Clip(string orgId, string clipId);
        Task<Playlist> Playlist(string orgId, string playlistId);
        Task<Playlists> Playlists(string orgId, string programId);
        Task<Clips> PlaylistsClips(string orgId, string playlistId, int cursor = 1, int pageSize = 25);
        Task<Program> Program(string orgId, string programId);
        Task<Clips> ProgramClips(string orgId, string programId, int cursor = 1, int pageSize = 25);
        Task<Programs> Programs(string orgId);
        Task<Transcript> Transcript(string orgId, string clipId);
    }
}