using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Secret_Message_Generator_2
{
    static class Letters
    {
        public static string A =
@"         99
        9999
       99  99
     99      99
    99        99
   99999999999999
  99            99
 99              99
99                99
99                99
";


        public static string B =
 @"
999999999999
99          99
99            99
99          99
99        99
99   9999
99       99
99         99
99           99
99          99
9999999999999 
";


        public static string C =
@"
       99999999
     99
   99
 99
99
99
 99
  99
    99
      999999999    
";
        public static string D =
@"
999999999999
99         99
99          99
99           99
99            99
99             99
99            99
99           99
99          99
9999999999999 
";
        public static string E =
@"
99999999999999
99
99
99
999999999
99
99
99
99
999999999999999
";
        public static string F =
@"
99999999999999
99
99
99
999999999
99
99
99
99
99
";
        public static string G =
@"
    9999999999
   99        99
 99
99
99
99
 99      99999999
  99          99
    99        99
      9999999999
";
        public static string H =
@"
99          99
99          99
99          99
99          99
99999999999999
99          99
99          99
99          99
99          99
99          99
";
        public static string I =
@"
999999999999999
      99
      99
      99
      99
      99
      99
      99
      99
999999999999999
";
        public static string J =
@"
999999999999999999
        99
        99
        99
        99
        99
        99
        99
99      99
  999999
";
        public static string K =
@"
99       99
99      99
99    99
99  999
9999
99  999
99    99
99      99
99        99
99         99
";
        public static string L =
@"
99
99
99
99
99
99
99
99
99
999999999999999
";
        public static string M =
@"
99             99 
999           999
9999         9999
99  99    99   99
99    99 99    99
99      99     99
99             99
99             99
99             99
99             99
";
        public static string N =
@"
99               99
999              99
99 9             99
99  99           99
99    99         99
99      99       99
99        99     99
99          99   99
99            99 99
99               99
";
        public static string O =
@"
      999999999
    99         99
  99             99
99                 99
99                 99
99                 99
99                 99
  99             99
    99         99
      999999999
";
        public static string P =
@"
99999999999999
99           99
99             99
99              99
99            99
99999999999999
99
99
99
99
";
        public static string Q =
@"
      999999999
    99         99
  99             99
99                 99
99                 99
99        99       99
99          99    99
  99         99  99
    99         99
      999999999  99
"; public static string R =
@"
99999999999
99        99
99          99
99         99
999999999999
99   99  
99     99
99       99
99         99
99           99
"; public static string S =
@"
     9999999999
    99        99
  99
 99
   99
     99 
       99
         99
99        99
  99999999 
";
        public static string T =
@"
999999999999999999999
         99
         99
         99
         99
         99
         99
         99
         99
         99
";
        public static string U =
@"
99                99
99                99
99                99
99                99
99                99
99                99
 99              99
  99            99
    99         99
      999999999
";
        public static string V =
@"
99               99
99               99
 99             99
  99           99
   99         99
    99       99
     99     99
      99   99
       99 99
        999
";
        public static string W =
@"
99                          99
99                          99
 99                        99
  99                      99
   99         99         99
    99       9999       99
     99     99  99     99
      99   99    99   99
       99 99      99 99
        999        999
";
        public static string X =
@"

99              99
  99          99
    99      99
      99  99
        99
        99
      99  99
    99      99
  99          99
99              99
";
        public static string Y =
@"
99                99
  99            99
    99        99
      99    99
       99  99
         99
         99
         99
         99
         99
";
        public static string Z =
@"
99999999999999999
               99
             99
           99
         99
       99
     99
   99
 99
9999999999999999
";

        public static string Space = 
            @"
                                
                                
                                
                                
                                
                                
                                
                                
                                 
                                 
";
        public static string[] GetLines(string text)
        {

            List<string> lines = new List<string>();
            using (MemoryStream ms = new MemoryStream())
            {
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(text);
                sw.Flush();

                ms.Position = 0;

                string line;

                using (StreamReader sr = new StreamReader(ms))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                sw.Close();
            }



            return lines.ToArray();
        }

        public static string getLetter(char c)
        {
            char cc = c.ToString().ToUpper().ToCharArray()[0];
            switch (cc)
            {
                case ' ':
                    return Space;
                case 'A':
                    return A;  
                case 'B':
                    return B;
                case 'C':
                    return C;
                case 'D':
                    return D;
                case 'E':
                    return E;
                case 'F':
                    return F;
                case 'G':
                    return G;
                case 'H':
                    return H;
                case 'I':
                    return I;
                case 'J':
                    return J;
                case 'K':
                    return K;
                case 'L':
                    return L;
                case 'M':
                    return M;
                case 'N':
                    return N;
                case 'O':
                    return O;
                case 'P':
                    return P;
                case 'Q':
                    return Q;
                case 'R':
                    return R;
                case 'S':
                    return S;
                case 'T':
                    return T;
                case 'U':
                    return U;
                case 'V':
                    return V;
                case 'W':
                    return W;
                case 'X':
                    return X;
                case 'Y':
                    return Y;
                case 'Z':
                    return Z;
            }
            throw new Exception("The character " + cc + " is not supported");
        }

        public static int MaxLetterLength(string letter)
        {
            int maxWidth = 0;
            string[] lines = null;
            switch(letter.ToUpper())
            {
                case " ":
                    lines = GetLines(Space);
                    break;
                case "A":
                    lines = GetLines(A);
                    break;
                case "B":
                    lines = GetLines(B);
                    break;
                case "C":
                    lines = GetLines(C);
                    break;
                case "D":
                    lines = GetLines(D);
                    break;
                case "E":
                    lines = GetLines(E);
                    break;
                case "F":
                    lines = GetLines(F);
                    break;
                case "G":
                    lines = GetLines(G);
                    break;
                case "H":
                    lines = GetLines(H);
                    break;
                case "I":
                    lines = GetLines(I);
                    break;
                case "J":
                    lines = GetLines(J);
                    break;
                case "K":
                    lines = GetLines(K);
                    break;
                case "L":
                    lines = GetLines(L);
                    break;
                case "M":
                    lines = GetLines(M);
                    break;
                case "N":
                    lines = GetLines(N);
                    break;
                case "O":
                    lines = GetLines(O);
                    break;
                case "P":
                    lines = GetLines(P);
                    break;
                case "Q":
                    lines = GetLines(Q);
                    break;
                case "R":
                    lines = GetLines(R);
                    break;
                case "S":
                    lines = GetLines(S);
                    break;
                case "T":
                    lines = GetLines(T);
                    break;
                case "U":
                    lines = GetLines(U);
                    break;
                case "V":
                    lines = GetLines(V);
                    break;
                case "W":
                    lines = GetLines(W);
                    break;
                case "X":
                    lines = GetLines(X);
                    break;
                case "Y":
                    lines = GetLines(Y);
                    break;
                case "Z":
                    lines = GetLines(Z);
                    break;
            }
            for (int i = 0; i < lines.Length; i++)
            {
                int count = lines[i].ToCharArray().Count();
                if (count > maxWidth)
                    maxWidth = count;
            }
            return maxWidth;
        }
    }

}
