using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Abstract;
using Resources.Entities;

namespace Resources.Concrete
{
    public class DbResourceProvider : BaseResourceProvider
    {
        // Database connection string        
        private static string connectionString = null;

        public DbResourceProvider(){

            //connectionString = ConfigurationManager.ConnectionStrings["MvcInternationalization"].ConnectionString;
            connectionString = ConfigurationManager.ConnectionStrings["GestorConnection"].ConnectionString;
        }

        public DbResourceProvider(string connection)
        {
            connectionString = connection;
        }

        protected override IList<ResourceEntry> ReadResources()
        {
            var resources = new List<ResourceEntry>();

            const string sql = "select IdGlobalization,Lang, label, OriginalText,TranslateText from Globalization;";

            using (var con = new SqlConnection(connectionString)) {
                var cmd = new SqlCommand(sql, con);

                con.Open();

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        resources.Add(new ResourceEntry {
                            IdGlobalization = int.Parse(reader["IdGlobalization"].ToString()),
                            Lang = reader["Lang"].ToString(),
                            label = reader["label"].ToString(),
                            OriginalText = reader["OriginalText"].ToString(),
                            TranslateText = reader["TranslateText"].ToString()
                        });
                    }

                    if (!reader.HasRows) throw new Exception("Nenhum recurso encontrado");
                }
            }

            return resources;
            
        }

        protected override ResourceEntry ReadResource(string label, string lang)
        {
            ResourceEntry resource = null;

            const string sql = "select IdGlobalization,Lang, label, OriginalText,TranslateText from Globalization where lang = @lang and label = @label;";

            using (var con = new SqlConnection(connectionString)) {
                var cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@lang", lang);
                cmd.Parameters.AddWithValue("@label", label);

                con.Open();

                using (var reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        resource = new ResourceEntry {
                            IdGlobalization = int.Parse(reader["IdGlobalization"].ToString()),
                            Lang = reader["Lang"].ToString(),
                            label = reader["label"].ToString(),
                            OriginalText = reader["OriginalText"].ToString(),
                            TranslateText = reader["TranslateText"].ToString()
                        };
                    }

                    if (!reader.HasRows) throw new Exception(string.Format("Resource {0} para o idioma {1} não foi encontrado", label, lang));
                }
            }

            return resource;            
           
        }

       

       
    }
}
