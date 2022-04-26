using System;
using EntityFramework.Part2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Part2.Repositories;
using EntityFramework.Part2;
using EntityFramework.Part2.Data;

namespace EntityFramework.Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationHelper configuration = ConfigurationHelper.Instance();
            var dbConnectionString = configuration.GetProperty<string>("DbConnectionString");
            //Console.WriteLine(dbConnectionString);

            using (RecruitmentContext context = new RecruitmentContext(dbConnectionString))
            {
                Console.WriteLine("Enter Employee Code");
                string code = Console.ReadLine();
                EmployeeData employeeData = new EmployeeData();

                EmployeeDataRepository employeeDataRepository = EmployeeDataRepository.Instance(context);
                try
                {
                    Employee verifiedEmployee = employeeDataRepository.GetEmployeeByCode(code);
                    employeeDataRepository.GetEmployeeData(verifiedEmployee.CEmployeeCode);
                    employeeDataRepository.GetMonthlySalary(verifiedEmployee.CEmployeeCode);
                    employeeDataRepository.GetAnnualSalary(verifiedEmployee.CEmployeeCode);
                    employeeDataRepository.GetEmployeeSkills(verifiedEmployee.CEmployeeCode);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
