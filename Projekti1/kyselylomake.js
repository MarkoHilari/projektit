function tarkista(){

var firsName = form.fName.value;
var secondName = form.sName.value;
var email = form.eMail.value;
var feedBack = form.fBack.value;
var commercial = form.commercial;
var check = form.box;

if(firstName.length < 5){
  alert("Anna vähintään 5-merkkinen etunimi.");
  form.fName.focus();
  return false;
}
if(secondName.length < 5){
  alert("Anna vähintäään 5-merkkinen sukunimi.");
  form.sName.focus();
  return false;
}
var ehdot = /\S+@\S+/;
if(!ehdot.test(email)){
  alert("Anna kunnon sähköposti.");
  form.eMail.focus();
  return false;
}

if(feedBack.length < 20){
  alert("Palautteessa pitää olla yli 20 merkkiä.");
  form.fBack.focus();
  return false;
}

var vastaus = false;
for(var i = 0; i < feedBack.length; i++){
  if(feedBack[i].checked == true){
    vastaus = true;
  }
}
if(vastaus == false){
  alert("Et ole valinnnut haluatko mainoksia");
return false;

for(var x = 0; x < check.length; x++)
  {
    if(check[x].checked == true)
    {
      checkvastaus = true;
    }
  }
  if(checkvastaus == false)
  {
    alert("Et valinnut, mikä on kivaa");
    return false;
  }
  else {
    alert("Kiitos lomakkeen täytöstä");
    return false;
  }
}
  function tyhjenna(lomake){
    var clean = lomake.value;
    if(!confirm("Oletko varma?")){
      return false;
    }
  }
