var app = angular.module('my-app', []);
app.controller('categoryAddCtrl', function($scope, $http) 
{
  $scope.createCategory = function() 
  {
    var data = {
        CategoryName: $scope.categoryName
      };
    $http.post("https://localhost:44373/api/category/add", data).then(function(resp) 
    {
      location.reload();

      alert("Category has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
