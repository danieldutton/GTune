using GTuner.Audio.Interfaces;
using System;
using System.Resources;

namespace GTuner.Audio
{
    public class WavResourceHandler : IResourceHandler
    {
        public object GetResource(string resourceName)
        {
            if(string.IsNullOrEmpty(resourceName)) 
                throw new ArgumentException("null or empty forbidden", "resourceName");

            ResourceManager resourceManager = Properties.Resources.ResourceManager;
            
            object wavResource = resourceManager.GetObject(resourceName);
            
            return wavResource;
        }
    }
}
