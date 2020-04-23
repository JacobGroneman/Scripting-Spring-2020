using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientDictionary : MonoBehaviour
{
    public string patientName;
    private int patientID {get;}

    public PatientDictionary (int patientID)
    {
        this.patientID = patientID;
    }
}

public class DictPlayerConnections : MonoBehaviour
{
    public Dictionary<int, PatientDictionary> hospitalPatientDictionary = new Dictionary<int, PatientDictionary>();
    
    void Start()
    {
        var p1 = new PatientDictionary(01) {patientName = "Bill"};
        var p2 = new PatientDictionary(02) {patientName = "Camille"};
        var p3 = new PatientDictionary(03) {patientName = "Xio"};
        hospitalPatientDictionary.Add(01, p1);
        hospitalPatientDictionary.Add(02, p2);
        hospitalPatientDictionary.Add(03, p3);

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var patient3 = hospitalPatientDictionary[3];
            UnityEngine.Debug.Log( patient3.patientName + " Selected");
        }
    }
}
