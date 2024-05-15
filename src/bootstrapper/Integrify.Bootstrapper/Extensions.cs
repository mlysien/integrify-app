namespace Integrify.Bootstrapper;

public static class Extensions
{
    public static void PrintBanner(this ILogger logger)
    {
        logger.LogInformation("""
                              
                               _____ _   _ _______ ______ _____ _____  _____ ________     __
                              |_   _| \ | |__   __|  ____/ ____|  __ \|_   _|  ____\ \   / /
                                | | |  \| |  | |  | |__ | |  __| |__) | | | | |__   \ \_/ /
                                | | | . ` |  | |  |  __|| | |_ |  _  /  | | |  __|   \   /
                               _| |_| |\  |  | |  | |___| |__| | | \ \ _| |_| |       | |
                              |_____|_| \_|  |_|  |______\_____|_|  \_\_____|_|       |_|
                                                                                            
                              """);
    }
}