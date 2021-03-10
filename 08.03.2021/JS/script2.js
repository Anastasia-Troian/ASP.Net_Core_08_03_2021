document.getElementById("animals").innerHTML = ``;
fetch("https://localhost:44312/Genre", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Genre: ${json.resultCollection[i].name}</h5>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))

function Delete(id) {
    fetch(`https://localhost:44312/Genre/Delete/${id}`, {
        method: "Post"
    })
        .then(response => response.json())
        .then(json => console.log(json))
        .catch(err => console.log(err))
    location.reload();
}

function Click_(id_,name_)
{
    console.log("hello")
    var obj = {
        id: id_,
        name: name_
    }
    localStorage.setItem("myObj", JSON.stringify(obj));
    window.location.replace("Edit.html")
}


function sortName(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Genre/SortName", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Genre: ${json.resultCollection[i].name}</h5>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

function sortNameD(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Genre/SortNameD", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Genre: ${json.resultCollection[i].name}</h5>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

