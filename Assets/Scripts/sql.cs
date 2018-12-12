using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.SqliteClient;
using System.Data;

public class sql : MonoBehaviour {
    public Text ab,op1,op2,op3;
    // Use this for initialization

    private void Awake()
    {
        string conn = "URI=file:" + Application.dataPath + "/game.db";
        IDbConnection dbconn;
        //Debug.Log(conn);
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); // Open connection to the database
        IDbCommand dbcmd = dbconn.CreateCommand();

        int value = staticx.value;

        string sqlQuery = "SELECT question, correct, op1, op2, op3 " + " from gamesQues where sr = "+value;
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        //Debug.Log(reader);

        while (reader.Read())
        {

            //int id = reader.GetInt32(0);
            string question = reader.GetString(0);
            ab.text = question;
            staticx.ans = reader.GetString(1);
            staticx.op1 = reader.GetString(2);
            staticx.op2 = reader.GetString(3);
            staticx.op3 = reader.GetString(4);

            op1.text = staticx.op1;
            op2.text = staticx.op2;
            op3.text = staticx.op3;
            //Debug.Log("Name: " + question);
            //Debug.Log(staticx.ans);
            //break;
        }

        reader.Close();
        dbcmd.Dispose();
        dbconn.Close();
    }
    void Start () {

	}

	void Update () {

	}
}
