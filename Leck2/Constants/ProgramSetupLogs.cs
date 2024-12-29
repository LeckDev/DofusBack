namespace Leck2.Constants
{
    public static class ProgramSetupLogs
    {
        public const string AppInitialisation = "Initialisation de l'application.";
        public const string AppStartupError = "Erreur lors du démarrage de l'application.";
        public const string InvalidProcessPathError = "Impossible de déterminer le chemin racine du contenu. Le chemin du processus est nul ou invalide.";
        public const string LoadingAppSettings = "Chargement des fichiers de paramètres de l'application (appsettings.json, appsettings.{Environment}.json, etc.).";
        public const string ConfiguringNLog = "Configuration de NLog en tant que fournisseur de log.";
        public const string ConfiguringKestrel = "Configuration du serveur Kestrel.";
        public const string AddingServices = "Ajout des services d'application.";
        public const string ConfiguringMiddleware = "Configuration du pipeline HTTP et des middlewares pour l'application.";
    }
}
