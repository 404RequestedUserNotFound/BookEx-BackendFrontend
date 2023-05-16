var app = angular.module('my-app', []);
app.controller('authorAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/author").then(function(resp){
        $scope.authors = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('authorDeleteCtrl', function ($scope, $http) {
    $scope.deleteAuthor = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this author?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/author/delete/" + id).then(function(resp){
                
            alert("Failed to delete author!");
            }, function (err) {
                location.reload();

                alert("Author deleted successfully!");
                console.log(err);
            });
        }
    };
});