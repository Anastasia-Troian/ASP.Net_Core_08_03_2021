document.getElementById("animals").innerHTML = ``;
fetch("https://localhost:44312/Films", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))

function Delete(id) {
    fetch(`https://localhost:44312/Films/Delete/${id}`, {
        method: "Post"
    })
        .then(response => response.json())
        .then(json => console.log(json))
        .catch(err => console.log(err))
    location.reload();
}

function Click_(id_,name_,year_,genre_)
{
    console.log("hello")
    var obj = {
        id: id_,
        name: name_,
        year: year_,
        genreName: genre_
    }
    localStorage.setItem("myObj", JSON.stringify(obj));
    window.location.replace("Edit2.html")
}

function sortName(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortName", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

function sortNameD(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortNameD", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

function sortAge(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortYear", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

function sortAgeD(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortYearD", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}


function sortType(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortGenre", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}

function sortTypeD(){
    document.getElementById("animals").innerHTML=``;
    fetch("https://localhost:44312/Films/SortGenreD", {
    method: "Get"
})
    .then(response => response.json())
    .then(json => {
        for (var i = 0; i < json.resultCollection.length; i++) {
            document.getElementById("animals").innerHTML += `
            <div style=" margin-right: 2%; margin-top: 1%;" class="card" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Name: ${json.resultCollection[i].name}</h5>
                    <h6 class="card-subtitle mb-2 text-muted">Genre: ${json.resultCollection[i].genreName}</h6>
                    <p class="card-text">Year: ${json.resultCollection[i].year}</p>
                    <button onclick='Click_(${json.resultCollection[i].id},"${json.resultCollection[i].name}",${json.resultCollection[i].year},"${json.resultCollection[i].genreName}");' class="btn btn-outline-dark">Edit</button>
                    <button onclick='Delete(${json.resultCollection[i].id});' class="btn btn-outline-dark">Delete</button>
                </div>
            </div>`;
        }
    })
    .catch(err => console.log(err))
}