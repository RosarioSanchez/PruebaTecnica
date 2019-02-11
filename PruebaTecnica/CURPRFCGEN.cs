using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class CURPRFCGEN
    {
        public String Nombre { get; set; }

        public String APaterno { get; set; }

        public String AMaterno { get; set; }

        public String Sexo { get; set; }

        public String FechaNacimiento { get; set; }

        public String EntidadFederativa { get; set; }
        
        public String CURP { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }

        public String CadenaDatos { get; set; }
        private int count { get; set; }

     

        public void ConsultaRFC()
        {
            try
            {

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("Datos");
                dt.Columns.Add(new DataColumn("RFC", typeof(string)));
                dt.Columns.Add(new DataColumn("CURP", typeof(string)));

                DataRow dr = dt.NewRow();
                dr["CURP"] = Get_CURP(this.Nombre, this.APaterno, this.AMaterno, this.Sexo, this.FechaNacimiento, this.EntidadFederativa);
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);
            }
            catch (Exception ex)
            {
                //this.Respuesta.Mensaje = ex.Message.ToString();
            }

            //return this.Respuesta;
        }

        public String Get_CURP(String Nombre, String APaterno, String AMaterno, String Sexo, String FechaNacimiento, String EntidadFederativa)
        {
            Sexo = Sexo.ToUpper();
            String setRFC = "", setCURP = "";
            String nom = ""; String nom2 = ""; String pat = ""; String pat2 = ""; String pat3 = ""; String NombreCompleto = "";
            String mat = ""; String mat2 = ""; String mat3 = ""; int count1 = 0;
            String RFC = ""; String nac = ""; String fecha = "";
            String pat1 = ""; int indice = -1;
            String inp = ""; String sexo = "";
            String entidadFederativa = "";
            String[] consonantes = new String[22];
            String[] invalidosacentos = { "Á", "À", "É", "È", "Í", "Ì", "Ó", "Ò", "Ú", "Ù" };
            String[] inconveniente = {"BUEI", "BUEY", "CACA", "CACO", "CAGA", "CAGO", "CAKA", "CAKO", "COGE", "COJA", "KOGE", "KOJO",
                                    "KAKA","KULO", "MAME", "MAMO", "MEAR", "MEAS", "MEON", "MION", "COJE", "COJI", "COJO", "CULO",
                                    "FETO", "GUEY","JOTO", "KACA", "KACO", "KAGA", "KAGO", "MOCO", "MULA", "PEDA", "PEDO", "PENE",
                                    "PUTA", "PUTO", "QULO","RATA", "RUIN", "GATA", "GATO"};
            //String[] nomnovalidos = {"MA.", "LA", "LAS", "MC", "VON", "DEL", "LOS", "Y", "MAC", "YAROT" };
            String[] nomnovalidos = { "JOSE", "JOSÉ", "MARIA", "MA.", "MA", "LA", "LAS", "MC", "VON", "DEL", "LOS", "Y", "MAC", "YAROT" };
            String[] apnovalidos = { "DEL", "DE", "LAS", "LA", "MC", "VON", "DEL", "MAC", "VAN", "LOS", "EK", "ES", "Y" };
            String consonanteap = ""; String consonanteam = "";
            int consonanteap_flag = 0; int consonanteam_flag = 0;
            String consonanteNombre = ""; String consonanteNombre2 = "";
            int consonanteNombre_flag = 0;
            String[] vocales = new String[5];
            String palabra = ""; String vocal = "";
            String hom; int hom2 = 0; int t_sum = 0; int multi = 0;
            String[] anio2; String nomNum = "";
            nom = Nombre;
            pat = APaterno;
            mat = AMaterno;
            nac = FechaNacimiento;
            fecha = FechaNacimiento;
            if (mat == null) { mat = ""; }
            NombreCompleto = (nom + " " + pat + " " + mat).ToUpper();


            if (nom != null && pat != null && nac != null)
            {
                pat2 = pat = pat.ToUpper();
                mat2 = mat = mat.ToUpper();
                nom2 = nom = nom.ToUpper();

                /**Erradicamos los acentos en las vocales**/
                for (int ace = 0; ace < invalidosacentos.Length; ace++)
                {
                    switch (invalidosacentos[ace])
                    {
                        case "Á": nom = nom.Replace(invalidosacentos[ace], "A"); break;
                        case "À": nom = nom.Replace(invalidosacentos[ace], "A"); break;
                        case "É": nom = nom.Replace(invalidosacentos[ace], "E"); break;
                        case "È": nom = nom.Replace(invalidosacentos[ace], "E"); break;
                        case "Í": nom = nom.Replace(invalidosacentos[ace], "I"); break;
                        case "Ì": nom = nom.Replace(invalidosacentos[ace], "I"); break;
                        case "Ó": nom = nom.Replace(invalidosacentos[ace], "O"); break;
                        case "Ò": nom = nom.Replace(invalidosacentos[ace], "O"); break;
                        case "Ú": nom = nom.Replace(invalidosacentos[ace], "U"); break;
                        case "Ù": nom = nom.Replace(invalidosacentos[ace], "U"); break;
                    }
                }
                /**Se obtiene la Primer letra del NOMBRE. Validamos si es un nombre compuesto**/
                string[] separa;
                separa = nom.Split(' ');
                int Palabras = 0;
                for (int i = 0; i < nom.Length; i++)
                {
                    if (nom == "JOSE MARIA")
                    {
                        if (Sexo == "M")
                        {
                            nom = nom.Replace(" ", "");
                            nom2 = nom = nom.Replace("JOSE", "");
                        }
                        else
                        {
                            nom = nom.Replace(" ", "");
                            nom2 = nom = nom.Replace("MARIA", "");
                        }
                    }
                    if (nom == "MARIA JOSE")
                    {
                        if (Sexo == "M")
                        {
                            nom = nom.Replace(" ", "");
                            nom2 = nom = nom.Replace("JOSE", "");
                        }
                        else
                        {
                            nom = nom.Replace(" ", "");
                            nom2 = nom = nom.Replace("MARIA", "");
                        }
                    }
                    if (nom[i] == ' ')
                    {
                        Palabras++;
                    }
                }

                if (Palabras == 1)
                {
                    if (separa[0] != separa[1])
                    {
                        nom = nom.Replace(" ", "");
                        for (int g = 0; g < nomnovalidos.Length; g++)
                        {
                            String nombrenovalido = "";
                            nombrenovalido = nomnovalidos[g].ToString();
                            if (separa[0] == nombrenovalido)
                            {
                                nom2 = nom = nom.Replace(nombrenovalido, "");
                            }

                        }
                    }
                }

                if (Palabras >= 2)
                {
                    nom = nom.Replace(" ", "");
                    for (int g = 0; g < nomnovalidos.Length; g++)
                    {
                        String nombrenovalido = "";
                        nombrenovalido = nomnovalidos[g].ToString();
                        for (int s = 0; s < separa.Length; s++)
                        {
                            if (separa[s] == nombrenovalido)
                            {
                                nom2 = nom = nom.Replace(nombrenovalido, "");
                            }

                        }

                    }
                }
                nom = nom.Substring(0, 1);
                if (pat == "" && mat != "")
                {
                    pat = mat;
                    mat = "";
                }

                /**Erradicamos los acentos en las vocales**/
                for (int ace = 0; ace < invalidosacentos.Length; ace++)
                {
                    switch (invalidosacentos[ace])
                    {
                        case "Á": pat = pat.Replace(invalidosacentos[ace], "A"); break;
                        case "À": pat = pat.Replace(invalidosacentos[ace], "A"); break;
                        case "É": pat = pat.Replace(invalidosacentos[ace], "E"); break;
                        case "È": pat = pat.Replace(invalidosacentos[ace], "E"); break;
                        case "Í": pat = pat.Replace(invalidosacentos[ace], "I"); break;
                        case "Ì": pat = pat.Replace(invalidosacentos[ace], "I"); break;
                        case "Ó": pat = pat.Replace(invalidosacentos[ace], "O"); break;
                        case "Ò": pat = pat.Replace(invalidosacentos[ace], "O"); break;
                        case "Ú": pat = pat.Replace(invalidosacentos[ace], "U"); break;
                        case "Ù": pat = pat.Replace(invalidosacentos[ace], "U"); break;
                    }
                }
                for (int ace = 0; ace < invalidosacentos.Length; ace++)
                {
                    switch (invalidosacentos[ace])
                    {
                        case "Á": mat = mat.Replace(invalidosacentos[ace], "A"); break;
                        case "À": mat = mat.Replace(invalidosacentos[ace], "A"); break;
                        case "É": mat = mat.Replace(invalidosacentos[ace], "E"); break;
                        case "È": mat = mat.Replace(invalidosacentos[ace], "E"); break;
                        case "Í": mat = mat.Replace(invalidosacentos[ace], "I"); break;
                        case "Ì": mat = mat.Replace(invalidosacentos[ace], "I"); break;
                        case "Ó": mat = mat.Replace(invalidosacentos[ace], "O"); break;
                        case "Ò": mat = mat.Replace(invalidosacentos[ace], "O"); break;
                        case "Ú": mat = mat.Replace(invalidosacentos[ace], "U"); break;
                        case "Ù": mat = mat.Replace(invalidosacentos[ace], "U"); break;

                    }
                }
                /**Se obtiene la primer vocal Interna del AP PATERNO y la Primer letra.**/
                int Palabras2 = 0;
                for (int i = 0; i < pat.Length; i++)
                {
                    if (pat[i] == ' ')
                    {
                        Palabras2++;
                    }
                }

                if (Palabras2 >= 1)
                {
                    for (int g = 0; g < apnovalidos.Length; g++)
                    {
                        String apnovalido = "";
                        apnovalido = apnovalidos[g].ToString();
                        pat = pat.Replace(apnovalido, "");
                    }
                }
                pat = pat.Replace(" ", "");
                if (pat != "")
                {
                    pat3 = pat;
                    pat = Convert.ToString(pat);
                    count1 = pat.Length;
                    pat1 = pat.Substring(0, 1);
                    String patSub = pat.Substring(1, (pat.Length - 1));

                    vocales[0] = Convert.ToString(patSub.IndexOf('A', 0));
                    vocales[1] = Convert.ToString(patSub.IndexOf('E', 0));
                    vocales[2] = Convert.ToString(patSub.IndexOf('I', 0));
                    vocales[3] = Convert.ToString(patSub.IndexOf('O', 0));
                    vocales[4] = Convert.ToString(patSub.IndexOf('U', 0));


                    for (int i = 0; i < patSub.Length; i++)
                    {

                        indice = patSub.ElementAt(i);

                        if (indice == 65)
                        {
                            vocal = "A";
                            break;
                        }
                        if (indice == 69)
                        {
                            vocal = "E";
                            break;
                        }
                        if (indice == 73)
                        {
                            vocal = "I";
                            break;
                        }
                        if (indice == 79)
                        {
                            vocal = "O";
                            break;
                        }
                        if (indice == 85)
                        {
                            vocal = "U";
                            break;
                        }

                    }
                    if (vocal == "")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            indice = Convert.ToInt32(vocales[i]);
                            for (int z = 0; z < 5; z++)
                            {
                                if (Convert.ToInt32(vocales[z]) != -1 || Convert.ToInt32(vocales[z]) < indice)
                                {
                                    vocal = patSub.Substring(Convert.ToInt16(vocales[z]), 1);
                                }
                                if (vocal != "")
                                {
                                    break;
                                }
                            }
                            if (vocal != "")
                            {
                                break;
                            }
                        }
                    }
                    if (vocal == "")
                    {
                        pat = pat.Substring(0, 1) + "X";
                    }
                    else
                    {
                        pat = pat.Substring(0, 1);
                    }
                }
                else
                {
                    pat = "X";
                }


                /**Se obtiene la Primer letra del AP MATERNO si no tiene se Coloca una x. Validamos si es un apellido compuesto**/
                if (mat != "")
                {
                    int Palabras3 = 0;
                    for (int i = 0; i < mat.Length; i++)
                    {
                        if (mat[i] == ' ')
                        {
                            Palabras3++;
                        }
                    }

                    if (Palabras3 >= 1)
                    {
                        for (int g = 0; g < apnovalidos.Length; g++)
                        {
                            String apnovalido = "";
                            apnovalido = apnovalidos[g].ToString();
                            mat = mat.Replace(apnovalido, "");
                        }
                    }
                    mat = mat.Replace(" ", "");
                    mat3 = mat;
                    if (mat != "")
                    {
                        mat = mat.Substring(0, 1);
                    }
                    else
                    {
                        mat = "X";
                    }
                }
                else
                {
                    mat = "X";
                }
                Console.WriteLine("PRIMER LETRA APELLIDO MATERNO: " + mat);

                /**Validamos que no sea una palabra Altisonante o Inconveniente**/
                if (pat == "X" && mat == "X")
                {
                    palabra = pat + "X" + mat + nom;
                }
                else
                {
                    palabra = pat + vocal + mat + nom;
                }
                for (int z = 0; z < inconveniente.Length; z++)
                {
                    if (palabra.Equals(inconveniente[z]))
                    {
                        palabra = pat + "X" + mat + nom;
                    }
                }

                /**SEXO**/
                if (Sexo != "G" && Sexo != "N" && Sexo != "S")
                {
                    if (Sexo.Equals("M"))
                    {
                        sexo = "H";
                    }
                    else
                    {
                        sexo = "M";
                    }

                }

                /**ENTIDAD FEDERATIVA**/

                entidadFederativa = EntidadFederativa;

                Console.WriteLine("pat3 " + pat3);
                consonantes[0] = ("B");
                consonantes[1] = ("C");
                consonantes[2] = ("D");
                consonantes[3] = ("F");
                consonantes[4] = ("G");
                consonantes[5] = ("H");
                consonantes[6] = ("J");
                consonantes[7] = ("K");
                consonantes[8] = ("L");
                consonantes[9] = ("M");
                consonantes[10] = ("N");
                consonantes[11] = ("Ñ");
                consonantes[12] = ("P");
                consonantes[13] = ("Q");
                consonantes[14] = ("R");
                consonantes[15] = ("S");
                consonantes[16] = ("T");
                consonantes[17] = ("V");
                consonantes[18] = ("W");
                consonantes[19] = ("X");
                consonantes[20] = ("Y");
                consonantes[21] = ("Z");


                /**Primer Consonante APP**/
                if (pat3 != "")
                {
                    for (int j = 1; j < pat3.Length; j++)
                    {
                        if (consonanteap_flag == 0)
                        {
                            consonanteap = pat3.Substring(j, 1);
                            Console.WriteLine(consonantes.Length + "--" + pat3.Length + "--" + consonanteap);
                            for (int k = 0; k < consonantes.Length; k++)
                            {
                                if (consonanteap.Equals(consonantes[k]) && consonanteap_flag == 0)
                                {
                                    if (consonanteap.Equals("Ñ"))
                                    {
                                        consonanteap = "X";
                                    }
                                    consonanteap_flag = 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    consonanteap = "X";
                }


                /**Primer Consonante APM**/
                if (mat3 != "")
                {
                    for (int j = 1; j < mat3.Length; j++)
                    {
                        if (consonanteam_flag == 0)
                        {
                            consonanteam = mat3.Substring(j, 1);
                            for (int k = 0; k < consonantes.Length; k++)
                            {
                                if (consonanteam.Equals(consonantes[k]) && consonanteam_flag == 0)
                                {
                                    if (consonanteam.Equals("Ñ"))
                                    {
                                        consonanteam = "X";
                                    }
                                    consonanteam_flag = 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    consonanteam = "X";
                }
                /**Primer Consonante Nombre**/
                String[] array = nom2.Split(' ');
                consonanteNombre = array[0].ToString();
                for (int j = 1; j < consonanteNombre.Length; j++)
                {
                    if (consonanteNombre_flag == 0)
                    {
                        consonanteNombre2 = consonanteNombre.Substring(j, 1);
                        for (int k = 0; k < consonantes.Length; k++)
                        {
                            if (consonanteNombre2.Equals(consonantes[k]) && consonanteNombre_flag == 0)
                            {
                                if (consonanteNombre2.Equals("Ñ"))
                                {
                                    consonanteNombre2 = "X";
                                }
                                consonanteNombre_flag = 1;
                            }
                        }
                    }
                }
                anio2 = fecha.Split('/');
                if (Int32.Parse(anio2[2]) < 2000)
                {
                    hom = "0";
                }

                else
                {
                    hom = "A";
                }

                /**NACIMIENTO**/
                String anio;
                String mes;
                String dia;
                anio = nac.Substring(8, 2);
                mes = nac.Substring(3, 2);
                dia = nac.Substring(0, 2);
                nac = anio + mes + dia;
                setRFC = (palabra + nac + inp);
                setCURP = (palabra + nac + inp + sexo + entidadFederativa + consonanteap + consonanteam + consonanteNombre2 + hom);

                /**CURP**/
                int ciclo = 0;
                while (ciclo < setCURP.Length)
                {
                    String test = "";
                    test = setCURP.Substring(ciclo, 1);
                    switch (test)
                    {
                        case "0": nomNum = nomNum + "00"; break;
                        case "1": nomNum = nomNum + "01"; break;
                        case "2": nomNum = nomNum + "02"; break;
                        case "3": nomNum = nomNum + "03"; break;
                        case "4": nomNum = nomNum + "04"; break;
                        case "5": nomNum = nomNum + "05"; break;
                        case "6": nomNum = nomNum + "06"; break;
                        case "7": nomNum = nomNum + "07"; break;
                        case "8": nomNum = nomNum + "08"; break;
                        case "9": nomNum = nomNum + "09"; break;
                        case "A": nomNum = nomNum + "10"; break;
                        case "B": nomNum = nomNum + "11"; break;
                        case "C": nomNum = nomNum + "12"; break;
                        case "D": nomNum = nomNum + "13"; break;
                        case "E": nomNum = nomNum + "14"; break;
                        case "F": nomNum = nomNum + "15"; break;
                        case "G": nomNum = nomNum + "16"; break;
                        case "H": nomNum = nomNum + "17"; break;
                        case "I": nomNum = nomNum + "18"; break;
                        case "J": nomNum = nomNum + "19"; break;
                        case "K": nomNum = nomNum + "20"; break;
                        case "L": nomNum = nomNum + "21"; break;
                        case "M": nomNum = nomNum + "22"; break;
                        case "N": nomNum = nomNum + "23"; break;
                        case "-": nomNum = nomNum + "24"; break;
                        case "O": nomNum = nomNum + "25"; break;
                        case "P": nomNum = nomNum + "26"; break;
                        case "Q": nomNum = nomNum + "27"; break;
                        case "R": nomNum = nomNum + "28"; break;
                        case "S": nomNum = nomNum + "29"; break;
                        case "T": nomNum = nomNum + "30"; break;
                        case "U": nomNum = nomNum + "31"; break;
                        case "V": nomNum = nomNum + "32"; break;
                        case "W": nomNum = nomNum + "33"; break;
                        case "X": nomNum = nomNum + "34"; break;
                        case "Y": nomNum = nomNum + "35"; break;
                        case "Z": nomNum = nomNum + "36"; break;
                        case "*": nomNum = nomNum + "37"; break;
                        default: nomNum = nomNum + "00"; break;
                    }
                    ciclo = ciclo + 1;
                }
                ciclo = 0;
                int multiplo = 0;
                while (ciclo <= 30)
                {
                    if (multiplo != 17)
                    {
                        multi = (Int32.Parse(nomNum.Substring(ciclo, 2)) * (18 - multiplo));
                        t_sum = t_sum + multi;
                    }
                    else
                    {
                    }
                    ciclo = ciclo + 2;
                    multiplo = multiplo + 1;
                }
                int residuo = t_sum % 10;

                if (residuo == 0)
                {
                    hom2 = 0;
                }
                else
                {
                    int resta = 10 - residuo;
                    hom2 = resta;
                }
                setCURP = (palabra + nac + inp + sexo + entidadFederativa + consonanteap + consonanteam + consonanteNombre2 + hom + hom2);
            }
            return setCURP;
            //return "CURP: " + Nombre + "-" + APaterno + "-" + AMaterno + "-" + Sexo + "-" + FechaNacimiento + "-" + EntidadFederativa;
        }

    }
}
