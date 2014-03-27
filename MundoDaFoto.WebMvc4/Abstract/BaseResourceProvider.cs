using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Entities;

namespace Resources.Abstract
{
    public abstract class BaseResourceProvider: IResourceProvider
    {
        // Cache list of resources
        private static Dictionary<string, ResourceEntry> resources = null;
        private static object lockResources = new object();

        public BaseResourceProvider() {
            Cache = true; // By default, enable caching for performance
        }

        protected bool Cache { get; set; } // Cache resources ?

        /// <summary>
        /// Returns a single resource for a specific culture
        /// </summary>
        /// <param name="label">Resorce name (ie key)</param>
        /// <param name="lang">Culture code</param>
        /// <returns>Resource</returns>
        public object GetResource(string label, string lang)
        {
            if (string.IsNullOrWhiteSpace(label))
                throw new ArgumentException("Resource name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(lang))
                throw new ArgumentException("Culture name cannot be null or empty.");

            // normalize
            lang = lang.ToLowerInvariant();

            if (Cache && resources == null) {
                // Fetch all resources
                
                lock (lockResources) {

                    if (resources == null)
                    {
                        resources = ReadResources().ToDictionary(r => string.Format("{0}.{1}", r.Lang, r.label));
                    }
                }
            }

            if (Cache) {
                return resources[string.Format("{0}.{1}", lang, label)].TranslateText;
            }

            return ReadResource(label, lang).TranslateText;

        }


        /// <summary>
        /// Returns all resources for all cultures. (Needed for caching)
        /// </summary>
        /// <returns>A list of resources</returns>
        protected abstract IList<ResourceEntry> ReadResources();


        /// <summary>
        /// Returns a single resource for a specific culture
        /// </summary>
        /// <param name="name">Resorce name (ie key)</param>
        /// <param name="culture">Culture code</param>
        /// <returns>Resource</returns>
        protected abstract ResourceEntry ReadResource(string name, string culture);
        
    }
}
