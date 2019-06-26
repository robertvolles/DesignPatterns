﻿using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;
using DesingPatterns2.Cap4;
using DesingPatterns2.Cap5;
using DesingPatterns2.Cap6;
using DesingPatterns2.Cap8;
using DesingPatterns2.Cap9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesingPatterns2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura)


            
            
                        
        }
    }
}
