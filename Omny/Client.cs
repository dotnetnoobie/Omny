using Omny.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Omny
{
    public class Client
    {
        private readonly HttpClient httpClient;

        public Client(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Programs> Programs(string orgId)
        {
            return await httpClient.GetFromJsonAsync<Programs>($"https://omny.fm/api/orgs/{orgId}/programs/");
        }

        public async Task<Program> Program(string orgId, string programId)
        {
            return await httpClient.GetFromJsonAsync<Program>($"https://omny.fm/api/orgs/{orgId}/programs/{programId} ");
        }

        public async Task<Clips> ProgramClips(string orgId, string programId, int cursor = 1, int pageSize = 25)
        {
            return await httpClient.GetFromJsonAsync<Clips>($"https://omny.fm/api/orgs/{orgId}/programs/{programId}/clips?cursor={cursor}&pageSize={pageSize}");
        }

        public async Task<Playlists> Playlists(string orgId, string programId)
        {
            return await httpClient.GetFromJsonAsync<Playlists>($"https://omny.fm/api/orgs/{orgId}/programs/{programId}/playlists");
        }

        public async Task<Playlist> Playlist(string orgId, string playlistId)
        {
            return await httpClient.GetFromJsonAsync<Playlist>($"https://omny.fm/api/orgs/{orgId}/playlists/{playlistId}");
        }

        public async Task<Clips> PlaylistsClips(string orgId, string playlistId, int cursor = 1, int pageSize = 25)
        {
            return await httpClient.GetFromJsonAsync<Clips>($"https://omny.fm/api/orgs/{orgId}/playlists/{playlistId}/clips?cursor={cursor}&pageSize={pageSize}");
        }

        public async Task<Clips> Clip(string orgId, string clipId)
        {
            return await httpClient.GetFromJsonAsync<Clips>($"https://omny.fm/api/orgs/{orgId}/clips/{clipId}");
        }

        public async Task<Transcript> Transcript(string orgId, string clipId)
        {
            return await httpClient.GetFromJsonAsync<Transcript>($"https://omny.fm/api/orgs/{orgId}/clips/{clipId}/transcript");
        } 
    }
}