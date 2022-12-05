let count = 0;
let temp = [];
function faultCode() {
  for(var i = 0; i < localStorage.length; i++)
  {
    temp[i] = localStorage.getItem(localStorage.key(i));
    console.log(temp[i]);
  }

  count++;
  alert("count " + count);
  let id = count;
  let brand = document.getElementById('brand').value;
  let model = document.getElementById('model').value;
  let fault = document.getElementById('fault').value;
  let type = document.getElementById('type').value;
  let tulosta =  "<b>ID: </b>" + id + "<br> <b>Merkki: </b>" + brand + " <br> <b>Malli: </b>" + model +  "<br><b> Vika: </b>" + fault + "<br><b> Tyyppi: </b>" + type;
  document.getElementById('nayta').innerHTML = tulosta;
//  document.getElementById('tulos').innerHTML = tulosta;

let car = {
  id: id,
  merkki: brand,
  malli: model,
  vika: fault,
  Tyyppi: type,
}
window.localStorage.setItem(id, JSON.stringify(car));
//document.getElementById('brand').innerHTML = "";
document.getElementById('model').value = "";
document.getElementById('fault').value = "";
document.getElementById('type').value = "";
document.getElementById('brand').value = "Merkki";

//window.localStorage.setItem(arvo, count);
}
function retrieveRecords(){
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



/*function retrieveRecords(){ //retrieves items in the localStorage

    console.log("retrieve records");
    console.log(localStorage);

    var i;
    var tulosta = "";
    console.log("local storage");
    for (i = 0; i < localStorage.length; i++)   {
      tulosta += (localStorage.key(i) + "=[" + localStorage.getItem(localStorage.key(i)) + "]") + "<br>";
    }

    document.getElementById('mobiili').innerHTML =  tulosta;
    let tulosta2 =  "<b>ID: </b>" + tulosta.id + "<br> <b>Merkki: </b>" + brand + " <br> <b>Malli: </b>" + model +  "<br><b> Vika: </b>" + fault + "<br><b> Tyyppi: </b>" + type;
    document.getElementById('nayta').innerHTML = tulosta2;

}*/
function removeItem(){ //deletes item from localStorage
    var key = document.getElementById('removeKey').value; //gets key from user
    localStorage.removeItem(key) //passes key to the removeItem method
    console.log("remove items");
}
function clearStorage(){
    //clears the entire localStorage
    localStorage.clear()
    console.log("clear records");
}
window.onload =function(){ //ensures the page is loaded before functions are executed.
    //document.getElementById("carForm").onsubmit = store

    document.getElementById("removeButton").onclick = removeItem
    document.getElementById("retrieveButton").onclick = retrieveRecords
    document.getElementById("clearButton").onclick = clearStorage
}
