var app = angular.module('my-app', []);
app.controller('publisherAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/publisher").then(function(resp){
        $scope.publishes = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('publisherDeleteCtrl', function ($scope, $http) {
    $scope.deletePublisher = function (id) {
         var confirmDelete = confirm("Are you sure you want to delete this Publisher?");
         if (confirmDelete) 
         {
            $http.get("https://localhost:44373/api/publisher/delete/" + id).then(function(resp){
                
            alert("Deleted Failed");
            }, function (err) 
            {
                location.reload();
                alert("Publisher deleted successfully!");                       
                console.log(err);
            });
         }
         else
         {
             alert("No, I don't want to delete");

         }
    };
});

