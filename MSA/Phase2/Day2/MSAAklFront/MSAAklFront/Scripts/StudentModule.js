// We've sepearated out all the functions related to making the AJAX calls to the API
// Just keeps things tidy, allows us to keep some things private
var StudentModule = (function () {
	
	// Return anything that you want to expose outside the closure
    return {
        getStudents: function (callback) {

            $.ajax({ 
                type: "GET",
                dataType: "json",
                url: "https://rajday2.azurewebsites.net/api/Students",
                success: function(data){        
                    console.log(data);
                    callback(data);
                }
             });
			
        }
	};
}());