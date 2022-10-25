using UC12_CLAB.Interfaces;
using System.Text.RegularExpressions;

namespace UC12_CLAB.Classes;

    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string ?cnpj {get;set;}
        public string ?razaoSoc {get;set;}

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            if (Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")){
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "9012")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8,4) == "9012")
                    {
                        return true;
                    }
                }     
            }
            return false;
        }
    }
