#pragma strict

var TheDamage : int = 50;
var Distance : float;
var MaxDiletDistance : float;
public var Hit : AudioSource;
public var Miss : AudioSource;

function Start(){

}

function Update (){
    if (Input.GetButtonDown("Fire1")){
        var hit : RaycastHit;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), hit)){
            Distance = hit.distance;
            if (Distance < MaxDiletDistance){
                hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
                Hit.Play();
            }else{
                Miss.Play();
            }
        }else{
            Miss.Play();
        }
    }
}