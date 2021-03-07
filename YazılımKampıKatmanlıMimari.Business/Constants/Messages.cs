using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.Entities.Concrete;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameExist = "Bu ürün adı ile aynı olan bir ürün bulunmaktadır.";
        public static string CategoryCountExceed = "Kategorideki ürün sayısı fazla";
        public static string MaintenanceTime ="Sistem bakımdadır";
        public static string ProductListed ="Ürünler listelendi";
        public static string AuthorizationDenied = "Yetkiniz yoktur.";
        public static string UserRegistered = "Kullanıcı kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
       
    }
}
