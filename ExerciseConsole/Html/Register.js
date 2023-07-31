$(document).ready(function () {

    $("#button").click(function () {
  
        debugger;
        
        alert("hello");
      
    
        // Get form values
        var FirstName = $("#FirstName").val();
        var LastName = $("#LastName").val();
        var Age = parseInt($("#Age").val());
        var Email = $("#Email").val();
        var Gender = $("#Gender").val();
        

         
    
        // Create JSON object
        var formData = {
          FirstName: FirstName,
          LastName: LastName,
          Age: Age,
          Email: Email,
          Gender: Gender
        };
    
        // Display JSON data in console
        console.log(formData);
    });
  
  });
  
  
    