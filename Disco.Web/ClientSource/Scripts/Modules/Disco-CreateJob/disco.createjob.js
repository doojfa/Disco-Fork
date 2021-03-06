﻿/// <reference path="../../Core/jquery-1.8.1.js" />
/// <reference path="../../Core/jquery-ui-1.8.23.js" />

(function ($, window, document) {
    $(function () {
        var createJobDialog = null;
        var dialogMethods = {
            close: function () {
                createJobDialog.dialog('close');
            },
            setButtons: function (buttons) {
                if (createJobDialog)
                    createJobDialog.dialog('option', 'buttons', buttons);
            }
        }

        if (!document.DiscoFunctions) {
            document.DiscoFunctions = {};
        }
        document.DiscoFunctions.CreateOpenJobDialog = function (url) {
            createJobDialog = $('<div>').attr('id', 'createJobDialog').css({ width: '100%', height: '100%', paddingTop: '0' }).appendTo(document.body);

            createJobDialog.dialog({
                resizable: false,
                draggable: false,
                modal: true,
                autoOpen: true,
                title: 'Create Job',
                width: 850,
                height: $(window).height() - 100,
                close: function () {
                    createJobDialog.find('iframe').attr('src', 'about:blank');
                    createJobDialog.dialog('destroy').remove();
                    createJobDialog = null;
                },
                buttons: {}
            });

            var iframe = $('<iframe>').attr({ 'src': url }).width('100%').height('100%').css('border', 'none').appendTo(createJobDialog);

            createJobDialog[0].discoDialogMethods = dialogMethods;
        }

        // Create Job Button
        $('#buttonCreateJob').click(function () {
            var $this = $(this);
            var href = $this.attr('href');
            
            document.DiscoFunctions.CreateOpenJobDialog(href);

            return false;
        });
    })
})($, window, document);