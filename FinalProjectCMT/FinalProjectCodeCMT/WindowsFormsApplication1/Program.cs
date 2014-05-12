using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectionMenu());
            

     


        }
    }


    //public roller(int f, int d)
    //    {
           //This code was created by Marty Fitzgerald and modified into the multiroller class by Chae`launa Tate
    //      while (n <= d)
    //      {
    //            dieroll = roll.Next(1, f + 1);
    //            showresult += Convert.ToString(dieroll) + ", ";
    //            result += dieroll;
    //           n++;
    //         }
    //     }

    //public class Variables
    //{

    //}
  
public class multiRoller
        {  //This was modified from Marty Fitzgerald's code.
            private Int32 facevalue;
            private Int32 diecount;
            private Int32 rollNumber;
            private string showresult;
            public int sum;
            public int[] RArray;
            public int[] totArray;
            Int32 result = 0;
            Int32 dieroll;
            
            public Random roll = new Random();
  public multiRoller(int fa, int di, int rnum)
            {
                facevalue = fa;
                diecount = di;
                rollNumber = rnum;
                RArray = new int[di];
                totArray = new int[rnum];
                int acount = 0;
                int count2 = 0;
                while (count2 < rnum)
                {
                    while (acount < di)
                    {
                        // sum += dieroll;
                        dieroll = roll.Next(1, fa + 1);
                        RArray[acount] = dieroll;
                        showresult += Convert.ToString(dieroll) + ", ";
                        result += dieroll;
                        acount++;
                    }

                    int min = RArray.Min();
                    RArray = RArray.Where(val => val != min).ToArray();
                    string arrayString = RArray.ToString();
                    sum = RArray.Sum();
                    totArray[count2] = sum;
                    count2++;
                    acount = 0;
                    RArray = new int[di];
                }
            }

            public Int32 Result
            {
                get { return result; }
            }


            public string ShowResult
            {
                get { return showresult; }
            }

            public int finalResult
            {
                get { return sum; }
            }

            public int[] multiFinalResult
            {
                get { return totArray; }
            }
            //end of roller class
        }


public class Charactervars
{
 
    public static int characterID
    {

        get { return charIDValue; }
        set { charIDValue= value; }
    }
    public static int charIDValue;

    public static string charName
    {
        get { return charNameValue; }
        set { charNameValue = value; }
    }
    private static string charNameValue;

    public static string pName
    {
        get { return pNameValue; }
        set { pNameValue = value; }
    }
    private static string pNameValue;
    public static string cclass
    {
        get { return cclassValue; }
        set { cclassValue = value; }
    }
    private static string cclassValue;
    public static int raceID
    {
        get { return raceIDValue; }
        set { raceIDValue = value; }
    }
    private static int raceIDValue;

    public static int age
    {
        get { return ageValue; }
        set { ageValue = value; }
    }
    private static int ageValue;
    public static int cLevel
    {
        get { return clevelValue; }
        set { clevelValue = value; }
    }
    private static int clevelValue;
    public static int ECL
    {
        get { return ECLValue; }
        set { ECLValue = value; }
    }
    private static int ECLValue;
    public static string size
    {
        get { return sizeValue; }
        set { sizeValue = value; }
    }
    private static string sizeValue;
    public static string gender
    {
        get { return genderValue; }
        set { genderValue = value; }
    }
    private static string genderValue;
    public static string alignment
    {
        get { return alignmentValue; }
        set { alignmentValue = value; }
    }
    private static string alignmentValue;
    public static string religon
    {
        get { return religonValue; }
        set { religonValue = value; }
    }
    private static string religonValue;
    public static int height
    {
        get { return heightValue; }
        set { heightValue = value; }
    }
    private static int heightValue;
    public static int cweight
    {
        get { return cweightValue; }
        set { cweightValue = value; }
    }
    private static int cweightValue;
    public static string cDescription
    {
        get { return cDescriptionValue; }
        set { cDescriptionValue = value; }
    }
    private static string cDescriptionValue;
    //I need to put something for my image here

    public static int touchAC
    {
        get { return touchACValue; }
        set { touchACValue = value; }
    }
    private static int touchACValue;
    public static int flatAC
    {
        get { return flatACValue; }
        set { flatACValue = value; }
    }
    private static int flatACValue;
    public static int hitPoints
    {
        get { return hitPointsValue; }
        set { hitPointsValue = value; }
    }
    private static int hitPointsValue;
    public static int experiencePoints
    {
        get { return experiencePointsValue; }
        set { experiencePointsValue = value; }
    }
    private static int experiencePointsValue;

    public static int lightCarry
    {
        get { return lightCarryValue; }
        set { lightCarryValue = value; }
    }
    private static int lightCarryValue;
    
    public static  int medCarry
    {
        get { return medCarryValue; }
        set { medCarryValue = value; }
    }
    private static int medCarryValue;
    public static int heavyCarry
    {
        get { return heavyCarryValue; }
        set { heavyCarryValue = value; }
    }

    private static int heavyCarryValue;

      public static int Strength
    {
        get { return StrengthValue; }
        set { StrengthValue = value; }
    }
    private static int StrengthValue;
    public static int Dex
    {
        get { return DexValue; }
        set { DexValue = value; }
    }
    private static int DexValue;

    public static int Con
    {
        get { return conValue; }
        set { conValue = value; }
    }
    private static int conValue;
    public static int Intell
    {
        get { return IntValue; }
        set { IntValue = value; }
    }
    private static int IntValue;

    public static int Wis
    {
        get { return wisValue; }
        set { wisValue = value; }
    }
    private static int wisValue;
   
    public static int Char
    {
        get { return charValue; }
        set { charValue = value; }
    }
    private static int charValue;

   public static string campaign
    {

        get { return campValue; }
        set { campValue = value; }
    }
    public static string campValue;

}

public class dbConnect
{
    public static void insertinfo(){

       // string insertCommand1 = "INSERT INTO Charactervars (name, Pname, class, raceID,age, clevel, ECL, Size, gender, alignment, religon, height, cweight, cdescription, touchAC, flatAC, hitPoints, experiencePoints, lightCarry, medCarry,baseStr,baseCon, baseInt, baseWis, baseChar) VALUES  (@NAM, @PNA, @CLAS, @RID, @CAG @CLVL, @ECL, @SIZ, @GEN, @ALI, @REL,@HEI, @WEI, @DES, @TOU, @FLA, @HIT, @EXP, @LCR, @MCR, @HCR, @BST, @BDE, @BCO, @BIN, @BWI, @BCH );";

        string insertCommand1 = "INSERT INTO Character (name,Pname,class,raceID,age," +
                                                           "clevel,ECL,Size,gender," +
                                                           "alignment,religon,height,cweight,cdescription," +
                                                           "touchAC,flatAC,hitPoints,experiencePoints,lightCarry," +
                                                           " medCarry,heavyCarry,baseStr,baseDex,baseCon," +
                                                           " baseInt,baseWis,baseChar, Campaign) " +
             "VALUES('" + Charactervars.charName + "','" + Charactervars.pName + "','" + Charactervars.cclass + "'," + Charactervars.raceID.ToString() + "," + Charactervars.age.ToString() + "," + Charactervars.cLevel.ToString() + "," +
                         Charactervars.ECL.ToString() + ",'" + Charactervars.size + "','" + Charactervars.gender + "','" + Charactervars.alignment + "','" +
                         Charactervars.religon + "'," + Charactervars.height.ToString() + "," + Charactervars.cweight.ToString() + ",'" + Charactervars.cDescription + "'," + Charactervars.touchAC.ToString() + "," +
                         Charactervars.flatAC.ToString() + " , " + Charactervars.hitPoints.ToString() + "," + Charactervars.experiencePoints.ToString() + "," + Charactervars.lightCarry.ToString() + "," + Charactervars.medCarry.ToString() + "," +
                         Charactervars.heavyCarry.ToString() + "," + Charactervars.Strength.ToString() + "," + Charactervars.Dex.ToString() + "," + Charactervars.Con.ToString() + "," + Charactervars.Intell.ToString() + "," +
                         Charactervars.Wis.ToString() + "," + Charactervars.Char.ToString() + ",'" + Charactervars.campaign + "');";
       // string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"../../DDChar.mdf;Integrated Security=True";
       // SqlConnection conn = new SqlConnection(connectionString);
        SqlConnection conn = new SqlConnection(global::CharacterCreator.Properties.Settings.Default.DDCharConnectionString1);
        try
        {
            
            SqlCommand command = new SqlCommand(insertCommand1, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert was successful");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"ERROR: INSERT WAS NOT SUCCESSFUL",MessageBoxButtons.OK);
        }

        }
    public static void getNum()
    {
        SqlConnection conn2 = new SqlConnection(global::CharacterCreator.Properties.Settings.Default.DDCharConnectionString1);

        try
        {
            string selectCommand = "SELECT TOP 1 CharID FROM Character ORDER BY CharID DESC";
            conn2.Open();
            SqlCommand command = new SqlCommand(selectCommand, conn2);
            Charactervars.characterID = (int)command.ExecuteScalar();
            conn2.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "ERROR: SELECT WAS NOT SUCCESSFUL");
        }
    }

}
}