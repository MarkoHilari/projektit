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

/*function retrieveRecords(){
  let key = document.getElementById('retrieveKey').value;
  console.log("retrive records");
  let records = window.localStorage.getItem(key);
  let paragraph = document.createElementById("retrieve");
  element.appendChild(paragraph);
}*/
function retrieveRecords(){ //retrieves items in the localStorage

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

      /*-

     var key = document.getElementById('retrieveKey').value;
    var records = window.localStorage.getItem(key);
    var paragraph = document.createElement("p");
    var infor = document.createTextNode(records);
    paragraph.appendChild(infor);
    var element = document.getElementById("retrieve");
    element.appendChild(paragraph);*/

}
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
