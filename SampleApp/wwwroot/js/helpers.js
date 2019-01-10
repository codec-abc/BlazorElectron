const { dialog } = require('electron').remote;

window.helpers =  {
    getFilePath: function(fileInput) {
        try {
            var path = fileInput.files[0].path;
            return path;
        } catch (e) {
            console.log(e);
            return "";
        }
    },

    showSaveDialog: function(e) {

        try {
            var userChosenPath = dialog.showSaveDialog();
            return userChosenPath;
        }
        catch (e) {
            console.log(e);
            return "";
        }
    }
}