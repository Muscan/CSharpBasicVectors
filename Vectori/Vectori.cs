using System;
using System.Collections.Generic;
using System.Text;

namespace Vectori
{
    class Vectori
    {

        public static void afisare(int[] v)
        {
            Console.WriteLine("Vectorul afisat");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");

            }
        }

        public static void sortareSelectie(int[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        int auxiliar = v[i];

                        v[i] = v[j];

                        v[j] = auxiliar;

                    }
                }

            }
        }
               /*
   parcurgere sortare
   int [] sortare={55,99,22,11,4,5}; int [31, 30, 29, 28, 27, 2]
   i<v.length-1    |     j<v.length    |    if (v[i] > v[j]) | 0  | 1 | 2  | 3  |  4  |  5  | j  |  i  |

   true(i=0)             true(j=1)            55>99 false    |    |   |    |                    2
                         true(j=2)            55>22  ade     |  22|   |  55|                    3
                         true(j=3)            22>11  a       |  11|   |    |  22                4
                         true(j=4)            11>4    a      |  4 |   |    |          11        5
                         true(j=5)            4>5f                  5                           6
                         false
     i<v.length-1    |     j<v.length    |    if (v[i] > v[j])|  aux |  0  | 1 | 2  | 3  |  4  |  5  | j  |  i  |
                                                                        31  30   29   28   27     2
     i=0<5 T              j=1,1<6T            31>30T              31    30  31                         1      0
     i=0<5 T              j=2,2<6T            30>29T              30    29       30                    2      0
     i=0<5 T              j=3,3<6T            29>28T              29    28            29               3      0
     i=0<5 T              j=4,4<6T            28>27T              28    27                  28         4      0
     i=0<5 T              j=5,5<6T            27>2 T              27    2                        27    5      0
     i=0<5 T              j=6,6<6F            -

     i=1<5 T              j=2,2<6T            31>30T              31         30   31                   2      1
     i=1<5 T              j=3,3<6T            30>29T              30         29        30              3      1
                          j=4,4<6T            29>28T              29         28              29        4      1
                          j=5,5<6T            28>27T              28         27                   28   5      1
                          j=6 -
     i=2<5T               j=3,3<6T            31>30T              31              30   31              3      2
                          j=4,4<6T            30>29T              30              29         30        4      2
                          j=5,5<6T            29>28T              29              28              29   5      2
                          j=6 -
     i=3<5T               j=4,4<6T            31>30               31                   30    31        4      3
                          j=5,5<6T            30>29T              30                   29         30   5      3
                          j=6 -
     i=4<5T               j=5,5<6T            31>30T              31                         30   31   5      4
     i=5<5F
                                                                         2   27   28   29    30    31


   */

        public static void bubbleSort(int[] v)
        {
            int check = 1;
            do
            {

                check = 1;

                for(int i=0; i<v.Length-1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;

                        check = 0;
                    }

                }
                
            } while (check == 0);

        }
        //Compara elementul curent cu elementul urmator
        //:e trece prin sir atata timp cat nu e ordonat(cand nu mai intra in IF, si toate sunt false, inseamna ca e sir ordonat)
        //if (v[i] > v[i + 1]) F
        //Daca se face interschimbare=> sirul nu e ordonat si flag devine 0
        //Daca nu se face(False)=> sirul e ordonat, si Flag ramane 1

        /* int [] sortare={55,99,22,11,4,5};
          flag 1 | i<v.length-1  |v[i]>v[i+1]| aux| v[i]| v[i+1]  | flag = 0| 0 |  1  |  2 |  3  | 4  | 5  |
                                                                             55 | 99  | 22 |  11 | 4  | 5  |
          1        0<5             F(55>99)    -
          0        1<5             T(99>22)    99    22    99                     22    99
          0        2<5             T(99>11)    99    11    99                           11    99
          0        3<5             T(99>4)     99    4     99                                 4    99
          0        4<5             T(99>5)     99    5     99                                       5   99
          0        5<5F

          1        0<5T            55>22T      55    22    55          0      22  55
          0        1<5T            55>11T      55    11    55          0          11    55
          0        2<5             55>4T       55     4    55          0                 4    55
          0        3<5             55>5T       55     5    55          0                       5   55
          0        4<5             55>99F                              0
          0        5<5F            -

          1        0<5             22>11T      22     11   22          0       11  22
          0        1<5             22>4T       22      4   22          0           4    22
          0        2<5T            22>5T       22      5   22          0                 5    22
          0        3<5T            22>55F
          0        4<5T            55>99F
          0        5<5F

          1        0<5             11>4T       11      4  11           0        4  11
          0        1<5             11>5T       11      5  11           0            5    11
          0        2<5             11>22F
          0        3<5             22>55F
          0        4<5             55>99F
          0        5<5F

          1        0<5             4>5F
          1        1<5             5>11F
          1        2<5             11>22F
          1        3<5             22>55F
          1        4<5             55>99F
          1        5<5F
                                                                               4   5    11  22   55  99


        flag 1 | i<v.length-1  |v[i]>v[i+1]| aux| v[i]| v[i+1]  | flag = 0| 0 |  1  |  2 |  3  | 4  | 5  |
                                                                            2 |  3  | 9  |  10 | 12 | 11 |
        1         0<5(6-1)       2>3 F
        1         1<5T           3>9 F
        1         2<5T           9>10F
        1         3<5T           10>12F
        0         4<5T           12>11T     12     11      12       0                            11   12

        1         0<5T           2>3F
        1         1<5T           3>9F
        1         2<5T           9>10F
        1         3<5T           10>11F
        1         4<5T           11>12F
        1         5<5F

        flag 1 | i<v.length-1  |v[i]>v[i+1]| aux| v[i]| v[i+1]  |flag == 0| 0 |  1  |  2 |  3  |
                                                                            1 |  2  | 2  |  9  |
        1         0<3 T          1>2F
        1         1<3 T          2>2F
        1         2<3 T          2>9F
        1         3<3F            -
                                                                  Flag == 1

        *
        * */

        public static bool binarySearch(int[] v , int key)
        {

            sortareSelectie(v);

            int primaValoare = 0;
            int ultimaValoare = v.Length;

            while (primaValoare <= ultimaValoare)
            {
                int auxiliar = (primaValoare + ultimaValoare) / 2;
                if (v[auxiliar] == key)
                {
                    return true;
                }
                else if (v[auxiliar] < key)
                {
                    primaValoare = auxiliar +1;
                }
                else
                {
                    ultimaValoare = auxiliar - 1;
                }

            }


            return false;



        }
        public static int[] stergere(int[] v, int pozitia)
        {
            for(int i = 0; i<v.Length-1; i++)
            {
                v[i] = v[i + 1];
            }


            int[] nou = new int[v.Length - 1];


            for(int i = 0; i < nou.Length; i++)
            {
                nou[i] = v[i];
            }


            return nou;


           
        }
        public static int[] inserare(int[] v, int pozitia, int nr)
        {
            int[] nou = new int[v.Length + 1];
            for (int i=0; i<v.Length; i++)
          
            {
                nou[i] = v[i];

            }
            for (int i = v.Length-1; i >=pozitia; i--)
            {
                nou[i + 1] = nou[i];

            }
            nou[pozitia] = nr;
            return nou;
        }
        
        

        }
    }   
