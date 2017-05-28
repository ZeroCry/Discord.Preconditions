# Discord.Preconditions
Some helpful preconditions for Discord C#

**RequireChannel**  
Usage:  
[RequireChannel("channelname")]  
Precondition for only allowing channels with the given name or starting with the given name to use a specific command  

**BanChannel**  
Usage:  
[BanChannel("channelname")]  
Makes a command unavailable to the given channel or any channel starting with the given name

**Examples**  
RequireChannel:  
        [Command("idk"), Summary("idk"), Remarks("I don't Know")]  
        [RequireChannel("memes")]  
        public async Task Idk()  
        {  
            await ReplyAsync(@"¯\_(ツ)_/¯");  
        }  

Command will only be useable in the channel #memes or any channel starting with #memes- (eg. #memes-hardcore)

BanChannel:
        [Command("idk"), Summary("idk"), Remarks("I don't Know")]  
        [BanChannel("Serious")]  
        public async Task Idk()  
        {  
            await ReplyAsync(@"¯\_(ツ)_/¯");  
        }  
        
Command will be banned from any channel titled #serious or starting with #serious- (eg. #serious-chat)        
