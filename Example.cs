using System.Threading.Tasks;
using Discord.Commands;
using PassiveBOT.preconditions;

namespace PassiveBOT.Commands
{
    public class Example : ModuleBase
    {
        [Command("rip")]
        [RequireChannel("memes")]
        public async Task Rip()
            =>await ReplyAsync("This command will only work in channels titled `memes` or starting with `memes-`");

        [Command("rekt")]
        [BanChannel("announcements")]
        public async Task Rekt()
            =>await ReplyAsync("this command will not work in any channel titled `announcements` or starting with `announcements-`");

        [Command("idk")]
        [RequireTopic("info")]
        public async Task Idk()
            =>await ReplyAsync("this command requires you include `[info]` in the topic of your channel");

        [Command("gg")]
        [BanTopic("help")]
        public async Task Gg() 
            =>await ReplyAsync("this command will not work in any channel with `[help]` in its topic");
    }
}
