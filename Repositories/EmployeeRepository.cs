using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Part2.Models;
using EntityFramework.Part2.Data;

namespace EntityFramework.Part2.Repositories
{
    public class EmployeeDataRepository
    {
        private static RecruitmentContext Context { get; set; }
        private static EmployeeDataRepository INSTANCE { get; set; }
        private EmployeeDataRepository(RecruitmentContext context)
        {
            Context = context;
        }

        public static EmployeeDataRepository Instance(RecruitmentContext context)
        {
            if (INSTANCE == null)
            {
                INSTANCE = new EmployeeDataRepository(context);
            }
            return INSTANCE;
        }

        public Employee GetEmployeeByCode(string code)
        {
            var employee = Context.Employees
                .Where(e => e.CEmployeeCode.Equals(code))
                .FirstOrDefault();
            if (employee == null)
            {
                throw new Exception("Employee Not found");
            }
            return employee;
        }
        public void GetEmployeeData(string code)
        {
            var employee = Context.Employees
            .Join(Context.Positions,
            e => e.CCurrentPosition,
            p => p.CPositionCode,
            (e, p) => new
            {
                EmployeeCode = e.CEmployeeCode,
                EmployeeFirstName = e.VFirstName,
                EmployeeLastName = e.VLastName,
                EmployeePosition = p.VDescription
            })
            .Where(e => e.EmployeeCode.Equals(code))
            .FirstOrDefault();

            if (employee is object)
            {

                Console.WriteLine($"Employee Code: {employee.EmployeeCode}\n" +
                    $"Employee Name: {employee.EmployeeFirstName} {employee.EmployeeLastName}\n" +
                    $"Position: {employee.EmployeePosition}\n");


            }
            else
            {
                Console.WriteLine("Employee Not found");
            }
        }
        public void GetMonthlySalary(string code)
        {
            var monthlySalaries = Context.MonthlySalaries
                .Select(e => e)
                .Where(e => e.CEmployeeCode.Equals(code))
                .ToList();

            Console.WriteLine("\nMonthly Salary\n");
            foreach (var salary in monthlySalaries)
            {
                Console.WriteLine(salary.MMonthlySalary);
            }
        }
        public void GetAnnualSalary(string code)
        {
            var annualSalaries = Context.AnnualSalaries
                .Select(e => e)
                .Where(e => e.CEmployeeCode.Equals(code))
                .ToList();

            Console.WriteLine("\nAnnual Salary\n");
            foreach (var salary in annualSalaries)
            {
                Console.WriteLine(salary.MAnnualSalary);
            }
        }
        public void GetEmployeeSkills(string code)
        {
            var skills = Context.EmployeeSkills
                .Join(Context.Skills,
                es => es.CSkillCode,
                s => s.CSkillCode,
                (es, s) => new
                {
                    EmployeeCode = es.CEmployeeCode,
                    SkillCode = es.CSkillCode,
                    Skill = s.VSkill
                })
                .Where(e => e.EmployeeCode.Equals(code))
                .ToList();

            Console.WriteLine("\nSkills\n");
            foreach (var skill in skills)
            {
                Console.WriteLine(skill.Skill);
            }
        }
    }
}
