using GitCommands.Settings;
            if (body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
            if (reset && body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
            var s = new StringBuilder();
            byte[] bs = Encoding.UTF8.GetBytes(input);
                result = result.Combine("\n", Application.ProductName + " " + AppSettings.GitExtensionsVersionString);