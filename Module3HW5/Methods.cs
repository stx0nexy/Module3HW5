using System.IO;
using System.Threading.Tasks;

namespace Module3HW5
{
    public class Methods
    {
        public async Task<string> GetAllTextAsync()
        {
            string hello = await GetHelloFileAsync();
            string world = await GetWorldFileAsync();
            return $"{hello} {world}";
        }

        private async Task<string> GetHelloFileAsync()
        {
            string hello = await File.ReadAllTextAsync("hello.txt");
            return hello;
        }

        private async Task<string> GetWorldFileAsync()
        {
            string world = await File.ReadAllTextAsync("world.txt");
            return world;
        }
    }
}
