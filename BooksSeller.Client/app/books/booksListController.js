(function () {
    "use strict";

    function booksListController( $scope, booksService) {
        var vm = this;

        $scope.vmMain.idBook = undefined;

        vm.edit = edit;
        vm.remove = remove;
        vm.addNewBook = addNewBook;

        
        getBooksList();

        function getBooksList() {
            booksService.getAll(function (books) {
                vm.books = books;
            });
        }
        

        function addNewBook() {
            $scope.vmMain.editionMode = true;
        }

        function edit(idBook) {
            $scope.vmMain.idBook = idBook;
            $scope.vmMain.editionMode = true;
        }

        function remove(idBook) {
            booksService.remove({ id: idBook }, function () {
                getBooksList();
            })
        }
        
    }

    angular
        .module("booksSeller")
        .controller("booksListController", 
            booksListController);
}());