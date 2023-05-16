var app = angular.module('my-app', []);
app.controller('categoryAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/category").then(function(resp){
        $scope.categories = resp.data;
    },function(err){
        console.log(err);
    });
  });



  app.controller('categoryDeleteCtrl', function ($scope, $http) {
    $scope.deleteCategory = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this category?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/category/delete/" + id).then(function(resp){
                
            alert("Failed to delete category!");
            }, function (err) {
                location.reload();

                alert("Category deleted successfully!");
                console.log(err);
            });
        }
    };
});