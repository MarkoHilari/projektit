let count = 0;
let temp = [];
function faultCode() {
  for(var i = 0; i < localStorage.length; i++)
  {
    temp[i] = localStorage.getItem(localStorage.key(i));
    console.log(temp[i]);
  }

  count++;
  alert("count " + count);//Laskuri joka laskee ja näyttää avaimen
  let id = count;
  let brand = document.getElementById('brand').value;
  let model = document.getElementById('model').value;
  let fault = document.getElementById('fault').value;
  let type = document.getElementById('type').value;
  let tulosta =  "<b>ID: </b>" + id + "<br> <b>Merkki: </b>" + brand + " <br> <b>Malli: </b>" + model +  "<br><b> Vika: </b>" + fault + "<br><b> Tyyppi: </b>" + type;
  document.getElementById('nayta').innerHTML = tulosta;

let car = {
  id: id,
  merkki: brand,
  malli: model,
  vika: fault,
  Tyyppi: type,
}
window.localStorage.setItem(id, JSON.stringify(car));
document.getElementById('model').value = "";
document.getElementById('fault').value = "";
document.getElementById('type').value = "";
document.getElementById('brand').value = "Merkki";

}
function retrieveRecords(){// palauttaa tietueen local storagesta
  for(var i = 0; i < localStorage.length; i++){
    var data = JSON.parse(localStorage.getItem(localStorage.key(i)));
    var paragraph = document.createElement("p");
    var infor = document.createTextNode(data.merkki);
    var infor2 = document.createTextNode(data.malli);
    var infor3 = document.createTextNode(data.vika);
    var teksti = document.createTextNode("Merkki: ");
    var teksti2 = document.createTextNode(" Malli: ");
    var teksti3 = document.createTextNode(" vika: ");
    var rivinvaihto = document.createElement("br");
    paragraph.appendChild(teksti);
    paragraph.appendChild(infor);
    paragraph.appendChild(rivinvaihto);
    paragraph.appendChild(teksti2);
    paragraph.appendChild(infor2);
    paragraph.appendChild(rivinvaihto);
    paragraph.appendChild(teksti3);
    paragraph.appendChild(infor3);
    var element = document.getElementById('mobiili');
    element.appendChild(paragraph);
  }
}

function removeItem(){ //poistaa tietueen local storagesta
    var key = document.getElementById('removeKey').value; //käyttän antama avain
    localStorage.removeItem(key) //välittää avaimen removeItem-menetelmälle
    console.log("remove items");
}
function clearStorage(){
    //koko muistin tyhjennys
    localStorage.clear()
    console.log("clear records");
}
window.onload =function(){ //Varmistaa että sivu latautuu ennenkuin functio ajetaan

    document.getElementById("removeButton").onclick = removeItem
    document.getElementById("retrieveButton").onclick = retrieveRecords
    document.getElementById("clearButton").onclick = clearStorage
}
