

function fetchData(){

    $.ajax({
        url: "/catalog/getCatalog",
        type: "Get",
        success: function(data){
            console.log("Server responded with", data);

            //travel the array
            // get each property
            // display property in html
        },
        error: function(details){
            console.log("Error", details);
        }

    });

}



function init(){
    console.log("Catalog page");

    fetchData();

}

window.onload = init;