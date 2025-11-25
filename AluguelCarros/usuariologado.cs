using System;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace AluguelCarros
{
    /// <summary>
    /// Classe estática para armazenar dados do usuário logado na sessão
    /// </summary>
    public static class Usuarioconectado
    {
        public static int ID_Usuario { get; set; }
        public static string Nome { get; set; }
        public static string Email { get; set; }
        public static string TipoUsuario { get; set; } // "Cliente", "Administrador", "AdminMaster"
        public static string CPF { get; set; }
        public static string CNH { get; set; }
        public static string Telefone { get; set; }

        /// <summary>
        /// Verifica se o usuário logado é um administrador (Administrador ou AdminMaster)
        /// </summary>
        public static bool EhAdministrador()
        {
            return TipoUsuario == "Administrador" || TipoUsuario == "AdminMaster";
        }

        /// <summary>
        /// Verifica se o usuário logado é o AdminMaster
        /// </summary>
        public static bool EhAdminMaster()
        {
            return TipoUsuario == "AdminMaster";
        }

        /// <summary>
        /// Limpa todos os dados da sessão
        /// </summary>
        public static void Limpar()
        {
            ID_Usuario = 0;
            Nome = null;
            Email = null;
            TipoUsuario = null;
            CPF = null;
            CNH = null;
            Telefone = null;
        }
    }
}

    /// <summary>
    /// Classe de utilitários para criptografia, validações e envio de email
    /// </summary>
