using System.Runtime.CompilerServices;

class Entraineur{
        public static void Main(string[] args){
            Welcome();
        }

        static void Welcome(){
            Console.Clear();
            Console.WriteLine("\nBonjour et bienvenue à votre entraineur aux opérations basiques mathématiques.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Veuillez choisir le type d'opération vous souhaitez vous entrainer: ");
            Console.WriteLine("[1] - Addition");
            Console.WriteLine("[2] - Soustraction");
            Console.WriteLine("[3] - Multiplication");
            Console.WriteLine("[4] - Division euclidienne\n");
            Console.WriteLine("Votre choix: "); string? answer = Console.ReadLine();
            switch(answer){
                case "1":
                DoAddition();
                break;
                case "2":
                DoSoustraction();
                break;
                case "3":
                DoMultiply();
                break;
                case "4":
                DoDivision();
                break;
                default:
                Console.Clear();
                Welcome();
                break;
            }

        static void DoAddition(){
            List<int> AdditionParams = GetAdditionParams();
            
            List<int> NewAddition = GetNewASM(AdditionParams[0], AdditionParams[1]);
            int result = GetAdditionResult(NewAddition);
            Console.Clear();
            Console.WriteLine("Voici l'addition que vous devrez effectuer: ");
            Console.WriteLine("  " + NewAddition[0]);
            for(int i = 1; i < NewAddition.Count(); i++){
                Console.WriteLine("+ " + NewAddition[i]);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Ecrivez votre résultat: ");
            int userResult = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(userResult == result){
                Console.WriteLine($"Félicitations, vous avez raison, le résultat est:  {result}");
            }else{
                Console.WriteLine($"Vous avez faux. Votre résultat: {userResult} n'est pas juste.");
                Console.WriteLine($"Le bon résultat était: {result}");
            }
            Loop();
        }

        static void DoSoustraction(){
            List<int> SoustractionParams = GetSoustractionParams();
            
            List<int> NewSoustraction = GetNewASM(SoustractionParams[0], SoustractionParams[1]);
            int result = GetSoustractionResult(NewSoustraction);
            Console.Clear();
            Console.WriteLine("Voici la soustraction que vous devrez effectuer: ");
            Console.WriteLine("  " + NewSoustraction[0]);
            for(int i = 1; i < NewSoustraction.Count(); i++){
                Console.WriteLine("- " + NewSoustraction[i]);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Ecrivez votre résultat: ");
            int userResult = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(userResult == result){
                Console.WriteLine($"Félicitations, vous avez raison, le résultat est:  {result}");
            }else{
                Console.WriteLine($"Vous avez faux. Votre résultat: {userResult} n'est pas juste.");
                Console.WriteLine($"Le bon résultat était: {result}");
            }
            Loop();
        }

        static void DoMultiply(){
            List<int> MultiplyParams = GetMultiplyParams();
            
            List<int> NewMultiply = GetNewASM(MultiplyParams[0], MultiplyParams[1]);
            int result = GetMultiplyResult(NewMultiply);
            Console.Clear();
            Console.WriteLine("Voici la multiplication que vous devrez effectuer: ");
            Console.WriteLine("  " + NewMultiply[0]);
            for(int i = 1; i < NewMultiply.Count(); i++){
                Console.WriteLine("x " + NewMultiply[i]);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Ecrivez votre résultat: ");
            int userResult = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(userResult == result){
                Console.WriteLine($"Félicitations, vous avez raison, le résultat est:  {result}");
            }else{
                Console.WriteLine($"Vous avez faux. Votre résultat: {userResult} n'est pas juste.");
                Console.WriteLine($"Le bon résultat était: {result}");
            }
            Loop();
        }

        static void DoDivision(){
            List<int> DivisionParams = GetDivisionParams();
            
            List<int> NewDivision = GetNewDivision(DivisionParams[0], DivisionParams[1]);
            List<int> result = GetDivisionResult(NewDivision);
            Console.Clear();
            Console.WriteLine("Voici la division euclidienne que vous devrez effectuer: ");
            Console.WriteLine($"{NewDivision[0]} / {NewDivision[1]}\n");
            Console.WriteLine("Ecrivez le quotient que vous avez trouvé: ");
            int userResultQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ecrivez le reste que vous avez trouvé: ");
            int userResultR = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(userResultQ == result[0] && userResultR == result[1]){
                Console.WriteLine($"Félicitations, vous avez raison, le quotient est:  {result[0]} et le reste est: {result[1]}");
            }else if(userResultQ != result[0] && userResultR == result[1]){
                Console.WriteLine($"Vous avez faux. Votre quotient: {userResultQ} n'est pas juste. Mais votre reste: {userResultR} est juste.");
                Console.WriteLine($"Le bon quotient était: {result[0]}");
            }else if(userResultQ == result[0] && userResultR != result[1]){
                Console.WriteLine($"Vous avez faux. Votre quotient: {userResultQ} est juste. Mais votre reste: {userResultR} n'est pas juste.");
                Console.WriteLine($"Le bon reste était: {result[1]}");
            }else if(userResultQ != result[0] && userResultR != result[1]){
                Console.WriteLine($"Vous avez faux. Votre quotient: {userResultQ} n'est pas juste. Et votre reste: {userResultR} n'est pas juste non plus.");
                Console.WriteLine($"Le bon quotient était: {result[0]} et le bon reste était: {result[1]}");
            }
            Loop();
        }

        static void Loop(){
            Console.WriteLine("\nVoulez-vous recommencer ?(O/N)");
            string? answer = Console.ReadLine();
            if(answer is not null){
                switch(answer.ToLower()){
                    case "o":
                    Welcome();
                    break;

                    case "oui":
                    Welcome();
                    break;

                    case "n":
                    Console.Clear();
                    Console.WriteLine("Aurevoir !\nAppuyez sur la touche entrée pour quitter");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

                    case "non":
                    Console.Clear();
                    Console.WriteLine("Aurevoir !\nAppuyez sur la touche entrée pour quitter");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

                }
            }
        }

        static List<int> GetAdditionParams(){
            Console.Clear();
            Console.WriteLine("Vous souhaitez vous entrainer sur des additions.\n");
            Console.WriteLine("Vous voulez faire des additions à combien de chiffres maximum ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer);
            }catch(System.FormatException){
                DoAddition();
            }
            Console.Clear();
            Console.WriteLine("Combien de lignes maximum voulez-vous que l'addition fasse ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer2 = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer2);
            }catch(System.FormatException){
                DoAddition();
            }
            List<int> additionParams = new List<int>{Convert.ToInt32(answer),Convert.ToInt32(answer2)};
            return additionParams;
        }

        static List<int> GetSoustractionParams(){
            Console.Clear();
            Console.WriteLine("Vous souhaitez vous entrainer sur des soustractions.\n");
            Console.WriteLine("Vous voulez faire des soustractions à combien de chiffres maximum ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer);
            }catch(System.FormatException){
                DoAddition();
            }
            Console.Clear();
            Console.WriteLine("Combien de lignes maximum voulez-vous que la soustraction fasse ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer2 = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer2);
            }catch(System.FormatException){
                DoAddition();
            }
            List<int> soustractionParams = new List<int>{Convert.ToInt32(answer),Convert.ToInt32(answer2)};
            return soustractionParams;
        }

        static List<int> GetMultiplyParams(){
            Console.Clear();
            Console.WriteLine("Vous souhaitez vous entrainer sur des multiplications.\n");
            Console.WriteLine("Vous voulez faire des multiplications à combien de chiffres maximum ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer);
            }catch(System.FormatException){
                DoAddition();
            }
            Console.Clear();
            Console.WriteLine("Combien de lignes maximum voulez-vous que la multiplication fasse ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer2 = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer2);
            }catch(System.FormatException){
                DoAddition();
            }
            List<int> multiplyParams = new List<int>{Convert.ToInt32(answer),Convert.ToInt32(answer2)};
            return multiplyParams;
        }

        static List<int> GetDivisionParams(){
            Console.Clear();
            Console.WriteLine("Vous souhaitez vous entrainer sur des divisions euclidiennes.\n");
            Console.WriteLine("Vous voulez faire une division euclidienne avec un dénominateur à combien de chiffres maximum ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer);
            }catch(System.FormatException){
                DoAddition();
            }
            Console.Clear();
            Console.WriteLine("Combien de chiffres maximum voulez-vous votre diviseur ?");
            Console.WriteLine("Entrez un nombre entier: ");
            string? answer2 = Console.ReadLine();
            try{
            int answer3 = Convert.ToInt32(answer2);
            }catch(System.FormatException){
                DoAddition();
            }
            List<int> divisionParams = new List<int>{Convert.ToInt32(answer),Convert.ToInt32(answer2)};
            return divisionParams;
        }

        static List<int> GetNewASM(int maxvalue, int maxrows){
            Random random = new Random();
            List<int> nouvelleASM = new List<int>();
            for(int i = 0; i < maxrows; i++){
                nouvelleASM.Add(random.Next(Convert.ToInt32(Math.Pow(10.0, Convert.ToDouble(maxvalue)))-1));
            }
            return nouvelleASM;
        }

        }

        static List<int> GetNewDivision(int nmaxvalue, int dmaxvalue){
            Random random = new Random();
            List<int> nouvelleDivision = new List<int>();
            nouvelleDivision.Add(random.Next(Convert.ToInt32(Math.Pow(10.0, Convert.ToDouble(nmaxvalue)))-1));
            nouvelleDivision.Add(random.Next(1, Convert.ToInt32(Math.Pow(10.0, Convert.ToDouble(dmaxvalue)))-1));

            return nouvelleDivision;
        }

        static int GetAdditionResult(List<int> addition){
            int result = 0;
            foreach(int i in addition){
                result += i;
            }   
            return result;     
        }

        static int GetSoustractionResult(List<int> soustraction){
            int result = soustraction[0];
            for(int i = 1; i < soustraction.Count(); i++){
                result -= soustraction[i];
            }   
            return result;     
        }

        static int GetMultiplyResult(List<int> multiplication){
            int result = multiplication[0];
            for(int i = 1; i < multiplication.Count(); i++){
                result *= multiplication[i];
            }   
            return result;     
        }

        static List<int> GetDivisionResult(List<int> division){
            int quotient = division[0] / division[1];
            int reste = division[0] % division[1];
            List<int> result = new List<int>{quotient, reste};
            return result;     
        }
}
