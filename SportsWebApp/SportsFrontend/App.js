function expand(){
    document.getElementById("getbyid").style.display="block";
}
function expand2(){
    document.getElementById("insertrec").style.display="block";
}
function expand3(){
    document.getElementById("searchbtn").style.display="block";
}

function allrec() {

    fetch("http://localhost:58432/Sports")
    .then(res=>res.text())
    .then(result=>showData(result))
   function showData(data)
   {
       document.getElementById('show').innerHTML=data;
   }
  }
  function singledata() {
    var id=document.getElementById("searchid").value;

    

    fetch("http://localhost:58432/Sports/"+id)

    .then((res) => res.text())

    .then(result => showData(result))  

    }
     
  function showData(data)

  {

      document.getElementById("show").innerHTML=data;

  }
   
  function sendJSON(){
			
    
    let sportsName = document.getElementById("sportname");
    let sportsType = document.getElementById("sporttype");
    let maxMembers = document.getElementById("maxmembers");
    
    // Creating a XHR object
    let xhr = new XMLHttpRequest();
    let url = "http://localhost:58432/Sports";

    // open a connection
    xhr.open("POST", url, true);

    // Set the request header i.e. which type of content you are sending
    xhr.setRequestHeader("Content-Type", "application/json");

    // Create a state change callback
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {

            // Print received data from server
            result.innerHTML = this.responseText;

        }
    };

    // Converting JSON data to string
    var data = JSON.stringify({  "sportsName": sportsName.value , "sportsType":sportsType.value, "maxMembers":maxMembers.value });

    // Sending data with the request
    xhr.send(data);
}

function like() {

    var id=document.getElementById("likeoperator").value;

    var url="http://localhost:58432/Sports/Sports/"+id;

    fetch(url)

    .then((res) => res.text())

    .then(ans => showData(ans))  

    }
  function showData(data)

  {

      document.getElementById("show").innerHTML=data;

  }




     