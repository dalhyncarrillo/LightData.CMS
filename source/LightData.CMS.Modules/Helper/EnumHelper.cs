﻿namespace LightData.CMS.Modules.Helper
{
    public static class EnumHelper
    {
        public enum RoleDefinition
        {
            User,
            Guest,
            Administrator,
            SuperAdmin,
            Developer
        }

        public enum Tags
        {
            Slider,
            HtmlContent,
            TopMenu,
            Menus,
            Footer
        }

        public enum AllowedFiles
        {
            PNG,
            GIF,
            JPEG,
            JPG,
            JAVASCRIPT,
            CSS
        }
    }
}
