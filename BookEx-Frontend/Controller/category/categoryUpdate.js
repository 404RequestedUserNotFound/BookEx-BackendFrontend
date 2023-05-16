var app = angular.module('my-app', []);
app.controller('categoryUpdateCtrl', function($scope, $http) 
{
  $scope.updateCategory = function() 
  {
    var data = {
        CategoryId: $scope.categoryId,
        CategoryName: $scope.categoryName
      };
    $http.post("https://localhost:44373/api/category/update", data).then(function(resp) 
    {
      location.reload();

      alert("Category name has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
