var app = angular.module('my-app', []);
app.controller('borrowAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/borrow").then(function(resp){
        $scope.borrows = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('borrowDeleteCtrl', function ($scope, $http) {
    $scope.deleteBorrow = function (id) {
         var confirmDelete = confirm("Are you sure you want to delete this borrow?");
         if (confirmDelete) 
         {
            $http.get("https://localhost:44373/api/borrow/delete/" + id).then(function(resp){
                
            alert("Deleted Failed");
            }, function (err) 
            {
                location.reload();
                alert("borrow deleted successfully!");                       
                console.log(err);
            });
         }
         else
         {
             alert("No, I don't want to delete");

         }
    };
});

