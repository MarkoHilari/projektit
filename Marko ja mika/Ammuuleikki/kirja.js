/*function aanet(elain)
var audio = new audio();
{
    audio.play();
}
  onmouseout= function(){
		audio.pause();
}*/
function aanet(elain)
{
  aani = elain.id;
  var audio = new Audio(aani+'.mp3');
  audio.play();
  onmouseout= function(){
		audio.pause();
}
}
