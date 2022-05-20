using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeBot
{
    public class General : ModuleBase
    {
        DiscordSocketClient _client = new DiscordSocketClient();

        public IMessageChannel channel;
        public bool Started;

        [Command("start")]
        public async Task start()
        {
            if (!Started)
            {
                Started = true;
                channel = Context.Channel;
                await Context.Channel.SendMessageAsync("sewer chat");
                DateTime time;
                time = DateTime.Now.AddHours(1);
                while (true)
                {
                    if (DateTime.Now.Hour == time.Hour)
                    {
                        time = DateTime.Now.AddHours(1);
                        await channel.SendMessageAsync("sewer chat");
                    }
                }
            }
        }
    }
}
