var app = angular.module('my-app', []);
app.controller('bookAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/book").then(function(resp){
        $scope.books = resp.data;
    },function(err){
        console.log(err);
    });
  });



  app.controller('bookDeleteCtrl', function ($scope, $http) {
    $scope.deleteBook = function (id) {
        var confirmDelete = confirm("Do you want to delete this book?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/book/delete/" + id).then(function(resp){
                
            alert("Failed to delete book!");
            }, function (err) {
                location.reload();

                alert("book deleted successfully!");
                console.log(err);
            });
        }
    };
});