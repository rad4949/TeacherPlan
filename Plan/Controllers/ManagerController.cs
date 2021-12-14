using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Plan.Data.Entities;
using Plan.intereces;
using Plan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ManagerController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly RoleManager<DbRole> _roleManager;
        private readonly IWebHostEnvironment _env;
        private readonly IRepository _repository;
        private readonly AppDBContent _appDBContent;

        public ManagerController(UserManager<DbUser> userManager,
            SignInManager<DbUser> signInManager,
            RoleManager<DbRole> roleManager, AppDBContent appDBContent,
            IRepository repository, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _appDBContent = appDBContent;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllTeacherTable(Filter filter, int page = 1)
        {
            var listUserName = _appDBContent.UserNames.ToList();
            var listDbUsers = _userManager.Users.ToList();

            ListAllUserViewModel model = new ListAllUserViewModel();
            model.listAllUser = new List<AllUserViewModel>();

            foreach (var item in listUserName)
            {
                model.listAllUser.Add(new AllUserViewModel
                {
                    Id = item.DbUserId,
                    Name = item.Name,
                    LastName = item.LastName,
                    Phone = listDbUsers.Where(s => s.Id == item.DbUserId).FirstOrDefault().PhoneNumber,
                    Email = listDbUsers.Where(s => s.Id == item.DbUserId).FirstOrDefault().Email,
                    Status = item.Status
                });
            }
            var query = (IEnumerable<AllUserViewModel>)new List<AllUserViewModel>();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = model.listAllUser.Where(x => x.Name.ToLower().Contains(filter.Name.ToLower()) ||
                            x.LastName.ToLower().Contains(filter.Name.ToLower()));
            }
            else
            {
                query = model.listAllUser;
            }
            int pageSize = 10;

            int pageNo = page - 1;
            model.listAllUser = query.OrderBy(x => x.Id)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult TeacherLayoutForManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            return View(user);
        }

        [HttpGet]
        public IActionResult CharacteristicGroupsTable1Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListCharacteristicGrups1ViewModel model = new ListCharacteristicGrups1ViewModel();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listCharacteristicGpoups = _appDBContent.Characteristic1Semestr.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult CharacteristicGroupsTable2Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListCharacteristicGrups2ViewModel model = new ListCharacteristicGrups2ViewModel();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listCharacteristicGpoups = _appDBContent.Characteristic2Semestr.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult LectureClassesTable1Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListLectureClasses1ViewModel model = new ListLectureClasses1ViewModel();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listLectureClasses = _appDBContent.LectureClassesSemestr1.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult LectureClassesTable2Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListLectureClasses2ViewModel model = new ListLectureClasses2ViewModel();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listLectureClasses = _appDBContent.LectureClassesSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult LectureClassesTableSumManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            ListLectureClassesSumViewModel model = new ListLectureClassesSumViewModel();
            ListLectureClasses1ViewModel listSemestr1 = new ListLectureClasses1ViewModel();
            ListLectureClasses2ViewModel listSemestr2 = new ListLectureClasses2ViewModel();

            LectureClassesTableSemestr1 sem1 = new LectureClassesTableSemestr1();
            LectureClassesTableSemestr1 sem2 = new LectureClassesTableSemestr1();
            LectureClassesTableSemestr1 all = new LectureClassesTableSemestr1();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            listSemestr1.listLectureClasses = _appDBContent.LectureClassesSemestr1.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            listSemestr2.listLectureClasses = _appDBContent.LectureClassesSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.listNameLectureClasses = _appDBContent.LectureClassesNameSums.ToList();
            model.listLectureClasses = new List<LectureClassesTableSemestr1>();

            foreach (var item in listSemestr1.listLectureClasses)
            {
                sem1.LectureBudPl += item.LectureBudPl;
                sem1.LectureBudVuc += item.LectureBudVuc;
                sem1.LectureConPl += item.LectureConPl;
                sem1.LectureConVuc += item.LectureConVuc;

                sem1.PractBudPl += item.PractBudPl;
                sem1.PractBudVuc += item.PractBudVuc;
                sem1.PractConPl += item.PractConPl;
                sem1.PractConVuc += item.PractConVuc;

                sem1.LabBudPl += item.LabBudPl;
                sem1.LabBudVuc += item.LabBudVuc;
                sem1.LabConPl += item.LabConPl;
                sem1.LabConVuc += item.LabConVuc;

                sem1.IndBudPl += item.IndBudPl;
                sem1.IndBudVuc += item.IndBudVuc;
                sem1.IndConPl += item.IndConPl;
                sem1.IndConVuc += item.IndConVuc;

                all.LectureBudPl += item.LectureBudPl;
                all.LectureBudVuc += item.LectureBudVuc;
                all.LectureConPl += item.LectureConPl;
                all.LectureConVuc += item.LectureConVuc;

                all.PractBudPl += item.PractBudPl;
                all.PractBudVuc += item.PractBudVuc;
                all.PractConPl += item.PractConPl;
                all.PractConVuc += item.PractConVuc;

                all.LabBudPl += item.LabBudPl;
                all.LabBudVuc += item.LabBudVuc;
                all.LabConPl += item.LabConPl;
                all.LabConVuc += item.LabConVuc;

                all.IndBudPl += item.IndBudPl;
                all.IndBudVuc += item.IndBudVuc;
                all.IndConPl += item.IndConPl;
                all.IndConVuc += item.IndConVuc;
            }

            foreach (var item in listSemestr2.listLectureClasses)
            {
                sem2.LectureBudPl += item.LectureBudPl;
                sem2.LectureBudVuc += item.LectureBudVuc;
                sem2.LectureConPl += item.LectureConPl;
                sem2.LectureConVuc += item.LectureConVuc;

                sem2.PractBudPl += item.PractBudPl;
                sem2.PractBudVuc += item.PractBudVuc;
                sem2.PractConPl += item.PractConPl;
                sem2.PractConVuc += item.PractConVuc;

                sem2.LabBudPl += item.LabBudPl;
                sem2.LabBudVuc += item.LabBudVuc;
                sem2.LabConPl += item.LabConPl;
                sem2.LabConVuc += item.LabConVuc;

                sem2.IndBudPl += item.IndBudPl;
                sem2.IndBudVuc += item.IndBudVuc;
                sem2.IndConPl += item.IndConPl;
                sem2.IndConVuc += item.IndConVuc;

                all.LectureBudPl += item.LectureBudPl;
                all.LectureBudVuc += item.LectureBudVuc;
                all.LectureConPl += item.LectureConPl;
                all.LectureConVuc += item.LectureConVuc;

                all.PractBudPl += item.PractBudPl;
                all.PractBudVuc += item.PractBudVuc;
                all.PractConPl += item.PractConPl;
                all.PractConVuc += item.PractConVuc;

                all.LabBudPl += item.LabBudPl;
                all.LabBudVuc += item.LabBudVuc;
                all.LabConPl += item.LabConPl;
                all.LabConVuc += item.LabConVuc;

                all.IndBudPl += item.IndBudPl;
                all.IndBudVuc += item.IndBudVuc;
                all.IndConPl += item.IndConPl;
                all.IndConVuc += item.IndConVuc;
            }

            model.listLectureClasses.Add(sem1);
            model.listLectureClasses.Add(sem2);
            model.listLectureClasses.Add(all);
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult ControlMeasuresTable1Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListControlMeasuresViewModelsSemestr1 model = new ListControlMeasuresViewModelsSemestr1();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listControlMeasures = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult ControlMeasuresTable2Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            ListControlMeasuresViewModelsSemestr2 model = new ListControlMeasuresViewModelsSemestr2();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            model.listControlMeasures = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult ControlMeasuresSumManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            ListSumControlMeasuresViewModels model = new ListSumControlMeasuresViewModels();
            ListControlMeasuresViewModelsSemestr1 listSemestr1 = new ListControlMeasuresViewModelsSemestr1();
            ListControlMeasuresViewModelsSemestr2 listSemestr2 = new ListControlMeasuresViewModelsSemestr2();

            ControlMeasuresSemestr1 sem1 = new ControlMeasuresSemestr1();
            ControlMeasuresSemestr1 sem2 = new ControlMeasuresSemestr1();
            ControlMeasuresSemestr1 all = new ControlMeasuresSemestr1();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            listSemestr1.listControlMeasures = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            listSemestr2.listControlMeasures = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.listNameControlMeasures = _appDBContent.LectureClassesNameSums.ToList();
            model.listSumControlMeasures = new List<ControlMeasuresSemestr1>();

            foreach (var item in listSemestr1.listControlMeasures)
            {
                sem1.ExamBudPl += item.ExamBudPl;
                sem1.ExamBudVuc += item.ExamBudVuc;
                sem1.ExamConPl += item.ExamConPl;
                sem1.ExamConVuc += item.ExamConVuc;

                sem1.TestBudPl += item.TestBudPl;
                sem1.TestBudVuc += item.TestBudVuc;
                sem1.TestConPl += item.TestConPl;
                sem1.TestConVuc += item.TestConVuc;

                sem1.KRBudPl += item.KRBudPl;
                sem1.KRBudVuc += item.KRBudVuc;
                sem1.KRConPl += item.KRConPl;
                sem1.KRConVuc += item.KRConVuc;

                sem1.CursProectBudPl += item.CursProectBudPl;
                sem1.CursProectBudVuc += item.CursProectBudVuc;
                sem1.CursProectConPl += item.CursProectConPl;
                sem1.CursProectConVuc += item.CursProectConVuc;

                sem1.CursRobBudPl += item.CursRobBudPl;
                sem1.CursRobBudVuc += item.CursRobBudVuc;
                sem1.CursRobConPl += item.CursRobConPl;
                sem1.CursRobConVuc += item.CursRobConVuc;

                sem1.RGRBudPl += item.RGRBudPl;
                sem1.RGRBudVuc += item.RGRBudVuc;
                sem1.RGRConPl += item.RGRConPl;
                sem1.RGRConVuc += item.RGRConVuc;

                sem1.DKRBudPl += item.DKRBudPl;
                sem1.DKRBudVuc += item.DKRBudVuc;
                sem1.DKRConPl += item.DKRConPl;
                sem1.DKRConVuc += item.DKRConVuc;

                sem1.AbstractBudPl += item.AbstractBudPl;
                sem1.AbstractBudVuc += item.AbstractBudVuc;
                sem1.AbstractConPl += item.AbstractConPl;
                sem1.AbstractConVuc += item.AbstractConVuc;

                sem1.CosultationBudPl += item.CosultationBudPl;
                sem1.CosultationBudVuc += item.CosultationBudVuc;
                sem1.CosultationConPl += item.CosultationConPl;
                sem1.CosultationConVuc += item.CosultationConVuc;



                all.ExamBudPl += item.ExamBudPl;
                all.ExamBudVuc += item.ExamBudVuc;
                all.ExamConPl += item.ExamConPl;
                all.ExamConVuc += item.ExamConVuc;

                all.TestBudPl += item.TestBudPl;
                all.TestBudVuc += item.TestBudVuc;
                all.TestConPl += item.TestConPl;
                all.TestConVuc += item.TestConVuc;

                all.KRBudPl += item.KRBudPl;
                all.KRBudVuc += item.KRBudVuc;
                all.KRConPl += item.KRConPl;
                all.KRConVuc += item.KRConVuc;

                all.CursProectBudPl += item.CursProectBudPl;
                all.CursProectBudVuc += item.CursProectBudVuc;
                all.CursProectConPl += item.CursProectConPl;
                all.CursProectConVuc += item.CursProectConVuc;

                all.CursRobBudPl += item.CursRobBudPl;
                all.CursRobBudVuc += item.CursRobBudVuc;
                all.CursRobConPl += item.CursRobConPl;
                all.CursRobConVuc += item.CursRobConVuc;

                all.RGRBudPl += item.RGRBudPl;
                all.RGRBudVuc += item.RGRBudVuc;
                all.RGRConPl += item.RGRConPl;
                all.RGRConVuc += item.RGRConVuc;

                all.DKRBudPl += item.DKRBudPl;
                all.DKRBudVuc += item.DKRBudVuc;
                all.DKRConPl += item.DKRConPl;
                all.DKRConVuc += item.DKRConVuc;

                all.AbstractBudPl += item.AbstractBudPl;
                all.AbstractBudVuc += item.AbstractBudVuc;
                all.AbstractConPl += item.AbstractConPl;
                all.AbstractConVuc += item.AbstractConVuc;

                all.CosultationBudPl += item.CosultationBudPl;
                all.CosultationBudVuc += item.CosultationBudVuc;
                all.CosultationConPl += item.CosultationConPl;
                all.CosultationConVuc += item.CosultationConVuc;
            }

            foreach (var item in listSemestr2.listControlMeasures)
            {
                sem2.ExamBudPl += item.ExamBudPl;
                sem2.ExamBudVuc += item.ExamBudVuc;
                sem2.ExamConPl += item.ExamConPl;
                sem2.ExamConVuc += item.ExamConVuc;

                sem2.TestBudPl += item.TestBudPl;
                sem2.TestBudVuc += item.TestBudVuc;
                sem2.TestConPl += item.TestConPl;
                sem2.TestConVuc += item.TestConVuc;

                sem2.KRBudPl += item.KRBudPl;
                sem2.KRBudVuc += item.KRBudVuc;
                sem2.KRConPl += item.KRConPl;
                sem2.KRConVuc += item.KRConVuc;

                sem2.CursProectBudPl += item.CursProectBudPl;
                sem2.CursProectBudVuc += item.CursProectBudVuc;
                sem2.CursProectConPl += item.CursProectConPl;
                sem2.CursProectConVuc += item.CursProectConVuc;

                sem2.CursRobBudPl += item.CursRobBudPl;
                sem2.CursRobBudVuc += item.CursRobBudVuc;
                sem2.CursRobConPl += item.CursRobConPl;
                sem2.CursRobConVuc += item.CursRobConVuc;

                sem2.RGRBudPl += item.RGRBudPl;
                sem2.RGRBudVuc += item.RGRBudVuc;
                sem2.RGRConPl += item.RGRConPl;
                sem2.RGRConVuc += item.RGRConVuc;

                sem2.DKRBudPl += item.DKRBudPl;
                sem2.DKRBudVuc += item.DKRBudVuc;
                sem2.DKRConPl += item.DKRConPl;
                sem2.DKRConVuc += item.DKRConVuc;

                sem2.AbstractBudPl += item.AbstractBudPl;
                sem2.AbstractBudVuc += item.AbstractBudVuc;
                sem2.AbstractConPl += item.AbstractConPl;
                sem2.AbstractConVuc += item.AbstractConVuc;

                sem2.CosultationBudPl += item.CosultationBudPl;
                sem2.CosultationBudVuc += item.CosultationBudVuc;
                sem2.CosultationConPl += item.CosultationConPl;
                sem2.CosultationConVuc += item.CosultationConVuc;



                all.ExamBudPl += item.ExamBudPl;
                all.ExamBudVuc += item.ExamBudVuc;
                all.ExamConPl += item.ExamConPl;
                all.ExamConVuc += item.ExamConVuc;

                all.TestBudPl += item.TestBudPl;
                all.TestBudVuc += item.TestBudVuc;
                all.TestConPl += item.TestConPl;
                all.TestConVuc += item.TestConVuc;

                all.KRBudPl += item.KRBudPl;
                all.KRBudVuc += item.KRBudVuc;
                all.KRConPl += item.KRConPl;
                all.KRConVuc += item.KRConVuc;

                all.CursProectBudPl += item.CursProectBudPl;
                all.CursProectBudVuc += item.CursProectBudVuc;
                all.CursProectConPl += item.CursProectConPl;
                all.CursProectConVuc += item.CursProectConVuc;

                all.CursRobBudPl += item.CursRobBudPl;
                all.CursRobBudVuc += item.CursRobBudVuc;
                all.CursRobConPl += item.CursRobConPl;
                all.CursRobConVuc += item.CursRobConVuc;

                all.RGRBudPl += item.RGRBudPl;
                all.RGRBudVuc += item.RGRBudVuc;
                all.RGRConPl += item.RGRConPl;
                all.RGRConVuc += item.RGRConVuc;

                all.DKRBudPl += item.DKRBudPl;
                all.DKRBudVuc += item.DKRBudVuc;
                all.DKRConPl += item.DKRConPl;
                all.DKRConVuc += item.DKRConVuc;

                all.AbstractBudPl += item.AbstractBudPl;
                all.AbstractBudVuc += item.AbstractBudVuc;
                all.AbstractConPl += item.AbstractConPl;
                all.AbstractConVuc += item.AbstractConVuc;

                all.CosultationBudPl += item.CosultationBudPl;
                all.CosultationBudVuc += item.CosultationBudVuc;
                all.CosultationConPl += item.CosultationConPl;
                all.CosultationConVuc += item.CosultationConVuc;
            }

            model.listSumControlMeasures.Add(sem1);
            model.listSumControlMeasures.Add(sem2);
            model.listSumControlMeasures.Add(all);
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult OtherTypesWorkTable1Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListOtherTypesWorkViewModel model = new ListOtherTypesWorkViewModel();
            model.otherTypesWorks = _appDBContent.OtherTypesWork.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.otherTypesWorks = model.otherTypesWorks.OrderBy(o => o.ColumId).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult OtherTypesWorkTable2Manager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListOtherTypesWorkSemestr2ViewModel model = new ListOtherTypesWorkSemestr2ViewModel();
            model.otherTypesWorks = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.otherTypesWorks = model.otherTypesWorks.OrderBy(o => o.ColumId).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult WorkloadSumManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            var firstSemestr = _appDBContent.WorkloadSum.Where(s => s.ColumId == 1
            && s.EmailTeacher == DbUsers.Email).FirstOrDefault();
            List<ControlMeasuresSemestr1> controlMeasures1 = new List<ControlMeasuresSemestr1>();
            controlMeasures1 = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            foreach (var item in controlMeasures1)
            {
                if (item.Id == 1)
                {
                    firstSemestr.TeachingBudPl = 0;
                    firstSemestr.TeachingBudVuc = 0;
                    firstSemestr.TeachingConPl = 0;
                    firstSemestr.TeachingConVuc = 0;

                    firstSemestr.OtherBudPl = 0;
                    firstSemestr.OtherBudVuc = 0;
                    firstSemestr.OtherConPl = 0;
                    firstSemestr.OtherConVuc = 0;

                    firstSemestr.AllBudPl = 0;
                    firstSemestr.AllBudVuc = 0;
                    firstSemestr.AllConPl = 0;
                    firstSemestr.AllConVuc = 0;
                }

                firstSemestr.TeachingBudPl += item.TestBudPl;
                firstSemestr.TeachingBudPl += item.RGRBudPl;
                firstSemestr.TeachingBudPl += item.KRBudPl;
                firstSemestr.TeachingBudPl += item.ExamBudPl;
                firstSemestr.TeachingBudPl += item.DKRBudPl;
                firstSemestr.TeachingBudPl += item.CursRobBudPl;
                firstSemestr.TeachingBudPl += item.CursProectBudPl;
                firstSemestr.TeachingBudPl += item.CosultationBudPl;
                firstSemestr.TeachingBudPl += item.AbstractBudPl;

                firstSemestr.TeachingBudVuc += item.TestBudVuc;
                firstSemestr.TeachingBudVuc += item.RGRBudVuc;
                firstSemestr.TeachingBudVuc += item.KRBudVuc;
                firstSemestr.TeachingBudVuc += item.ExamBudVuc;
                firstSemestr.TeachingBudVuc += item.DKRBudVuc;
                firstSemestr.TeachingBudVuc += item.CursRobBudVuc;
                firstSemestr.TeachingBudVuc += item.CursProectBudVuc;
                firstSemestr.TeachingBudVuc += item.CosultationBudVuc;
                firstSemestr.TeachingBudVuc += item.AbstractBudVuc;

                firstSemestr.TeachingConPl += item.TestConPl;
                firstSemestr.TeachingConPl += item.RGRConPl;
                firstSemestr.TeachingConPl += item.KRConPl;
                firstSemestr.TeachingConPl += item.ExamConPl;
                firstSemestr.TeachingConPl += item.DKRConPl;
                firstSemestr.TeachingConPl += item.CursRobConPl;
                firstSemestr.TeachingConPl += item.CursProectConPl;
                firstSemestr.TeachingConPl += item.CosultationConPl;
                firstSemestr.TeachingConPl += item.AbstractConPl;

                firstSemestr.TeachingConVuc += item.TestConVuc;
                firstSemestr.TeachingConVuc += item.RGRConVuc;
                firstSemestr.TeachingConVuc += item.KRConVuc;
                firstSemestr.TeachingConVuc += item.ExamConVuc;
                firstSemestr.TeachingConVuc += item.DKRConVuc;
                firstSemestr.TeachingConVuc += item.CursRobConVuc;
                firstSemestr.TeachingConVuc += item.CursProectConVuc;
                firstSemestr.TeachingConVuc += item.CosultationConVuc;
                firstSemestr.TeachingConVuc += item.AbstractConVuc;
            }

            List<OtherTypesWork> otherTypes1 = new List<OtherTypesWork>();
            otherTypes1 = _appDBContent.OtherTypesWork.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            foreach (var item in otherTypes1)
            {
                if (item.ColumId != 34)
                {
                    firstSemestr.OtherBudPl += item.HoursBudPl;
                    firstSemestr.OtherBudVuc += item.HoursBudVuc;
                    firstSemestr.OtherConPl += item.HoursConPl;
                    firstSemestr.OtherConVuc += item.HoursConVuc;
                }
            }

            firstSemestr.AllBudPl += firstSemestr.TeachingBudPl;
            firstSemestr.AllBudVuc += firstSemestr.TeachingBudVuc;
            firstSemestr.AllConPl += firstSemestr.TeachingConPl;
            firstSemestr.AllConVuc += firstSemestr.TeachingConVuc;

            firstSemestr.AllBudPl += firstSemestr.OtherBudPl;
            firstSemestr.AllBudVuc += firstSemestr.OtherBudVuc;
            firstSemestr.AllConPl += firstSemestr.OtherConPl;
            firstSemestr.AllConVuc += firstSemestr.OtherConVuc;
            _appDBContent.SaveChanges();

            var secondSemestr = _appDBContent.WorkloadSum.Where(s => s.ColumId == 2
            && s.EmailTeacher == DbUsers.Email).FirstOrDefault();
            List<ControlMeasuresSemestr2> controlMeasures2 = new List<ControlMeasuresSemestr2>();
            controlMeasures2 = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            foreach (var item in controlMeasures2)
            {
                if (item.Id == 1)
                {
                    secondSemestr.TeachingBudPl = 0;
                    secondSemestr.TeachingBudVuc = 0;
                    secondSemestr.TeachingConPl = 0;
                    secondSemestr.TeachingConVuc = 0;

                    secondSemestr.OtherBudPl = 0;
                    secondSemestr.OtherBudVuc = 0;
                    secondSemestr.OtherConPl = 0;
                    secondSemestr.OtherConVuc = 0;

                    secondSemestr.AllBudPl = 0;
                    secondSemestr.AllBudVuc = 0;
                    secondSemestr.AllConPl = 0;
                    secondSemestr.AllConVuc = 0;
                }

                secondSemestr.TeachingBudPl += item.TestBudPl;
                secondSemestr.TeachingBudPl += item.RGRBudPl;
                secondSemestr.TeachingBudPl += item.KRBudPl;
                secondSemestr.TeachingBudPl += item.ExamBudPl;
                secondSemestr.TeachingBudPl += item.DKRBudPl;
                secondSemestr.TeachingBudPl += item.CursRobBudPl;
                secondSemestr.TeachingBudPl += item.CursProectBudPl;
                secondSemestr.TeachingBudPl += item.CosultationBudPl;
                secondSemestr.TeachingBudPl += item.AbstractBudPl;

                secondSemestr.TeachingBudVuc += item.TestBudVuc;
                secondSemestr.TeachingBudVuc += item.RGRBudVuc;
                secondSemestr.TeachingBudVuc += item.KRBudVuc;
                secondSemestr.TeachingBudVuc += item.ExamBudVuc;
                secondSemestr.TeachingBudVuc += item.DKRBudVuc;
                secondSemestr.TeachingBudVuc += item.CursRobBudVuc;
                secondSemestr.TeachingBudVuc += item.CursProectBudVuc;
                secondSemestr.TeachingBudVuc += item.CosultationBudVuc;
                secondSemestr.TeachingBudVuc += item.AbstractBudVuc;

                secondSemestr.TeachingConPl += item.TestConPl;
                secondSemestr.TeachingConPl += item.RGRConPl;
                secondSemestr.TeachingConPl += item.KRConPl;
                secondSemestr.TeachingConPl += item.ExamConPl;
                secondSemestr.TeachingConPl += item.DKRConPl;
                secondSemestr.TeachingConPl += item.CursRobConPl;
                secondSemestr.TeachingConPl += item.CursProectConPl;
                secondSemestr.TeachingConPl += item.CosultationConPl;
                secondSemestr.TeachingConPl += item.AbstractConPl;

                secondSemestr.TeachingConVuc += item.TestConVuc;
                secondSemestr.TeachingConVuc += item.RGRConVuc;
                secondSemestr.TeachingConVuc += item.KRConVuc;
                secondSemestr.TeachingConVuc += item.ExamConVuc;
                secondSemestr.TeachingConVuc += item.DKRConVuc;
                secondSemestr.TeachingConVuc += item.CursRobConVuc;
                secondSemestr.TeachingConVuc += item.CursProectConVuc;
                secondSemestr.TeachingConVuc += item.CosultationConVuc;
                secondSemestr.TeachingConVuc += item.AbstractConVuc;
            }

            List<OtherTypesWorkSemestr2> otherTypes2 = new List<OtherTypesWorkSemestr2>();
            otherTypes2 = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            foreach (var item in otherTypes2)
            {
                if (item.ColumId != 34)
                {
                    secondSemestr.OtherBudPl += item.HoursBudPl;
                    secondSemestr.OtherBudVuc += item.HoursBudVuc;
                    secondSemestr.OtherConPl += item.HoursConPl;
                    secondSemestr.OtherConVuc += item.HoursConVuc;
                }
            }

            secondSemestr.AllBudPl += secondSemestr.TeachingBudPl;
            secondSemestr.AllBudVuc += secondSemestr.TeachingBudVuc;
            secondSemestr.AllConPl += secondSemestr.TeachingConPl;
            secondSemestr.AllConVuc += secondSemestr.TeachingConVuc;

            secondSemestr.AllBudPl += secondSemestr.OtherBudPl;
            secondSemestr.AllBudVuc += secondSemestr.OtherBudVuc;
            secondSemestr.AllConPl += secondSemestr.OtherConPl;
            secondSemestr.AllConVuc += secondSemestr.OtherConVuc;
            _appDBContent.SaveChanges();

            var AllSemestr = _appDBContent.WorkloadSum.Where(s => s.ColumId == 3
            && s.EmailTeacher == DbUsers.Email).FirstOrDefault();
            List<WorkloadSum> workloadSums = _appDBContent.WorkloadSum.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            foreach (var item in workloadSums)
            {
                if (item.Id == 1)
                {
                    AllSemestr.TeachingBudPl = 0;
                    AllSemestr.TeachingBudVuc = 0;
                    AllSemestr.TeachingConPl = 0;
                    AllSemestr.TeachingConVuc = 0;

                    AllSemestr.OtherBudPl = 0;
                    AllSemestr.OtherBudVuc = 0;
                    AllSemestr.OtherConPl = 0;
                    AllSemestr.OtherConVuc = 0;

                    AllSemestr.AllBudPl = 0;
                    AllSemestr.AllBudVuc = 0;
                    AllSemestr.AllConPl = 0;
                    AllSemestr.AllConVuc = 0;
                }
                if (item.Id < 3)
                {
                    AllSemestr.TeachingBudPl += item.TeachingBudPl;
                    AllSemestr.TeachingBudVuc += item.TeachingBudVuc;
                    AllSemestr.TeachingConPl += item.TeachingConPl;
                    AllSemestr.TeachingConVuc += item.TeachingConVuc;

                    AllSemestr.OtherBudPl += item.OtherBudPl;
                    AllSemestr.OtherBudVuc += item.OtherBudVuc;
                    AllSemestr.OtherConPl += item.OtherConPl;
                    AllSemestr.OtherConVuc += item.OtherConVuc;

                    AllSemestr.AllBudPl += item.AllBudPl;
                    AllSemestr.AllBudVuc += item.AllBudVuc;
                    AllSemestr.AllConPl += item.AllConPl;
                    AllSemestr.AllConVuc += item.AllConVuc;
                }
            }
            _appDBContent.SaveChanges();

            WorkloadSumViewModel workloadSumViewModel = new WorkloadSumViewModel();
            workloadSumViewModel.listWorkloadSum = _appDBContent.WorkloadSum.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            workloadSumViewModel.listWorkloadSum = workloadSumViewModel.listWorkloadSum.OrderBy(o => o.ColumId).ToList();
            workloadSumViewModel.userModel = user;
            return View(workloadSumViewModel);
        }

        [HttpGet]
        public IActionResult MethodicalWorkTableManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListMethodicalWorkViewModel model = new ListMethodicalWorkViewModel();
            model.methodicalWorks = _appDBContent.MethodicalWork.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult ScientificWorkTableManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListScientificWorkViewModel model = new ListScientificWorkViewModel();
            model.scientificWorks = _appDBContent.ScientificWork.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult OrganizationalWorkTableManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListOrganizationalWorkViewModel model = new ListOrganizationalWorkViewModel();
            model.organizationalWorks = _appDBContent.OrganizationalWork.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult EducationalActivitiesTableManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListEducationalActivitiesViewModel model = new ListEducationalActivitiesViewModel();
            model.educationalActivities = _appDBContent.EducationalActivities.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult ChangesWorkPlanTableManager(int id)
        {
            AllUserViewModel user = new AllUserViewModel();
            var UserName = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var DbUsers = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();

            user.Id = UserName.DbUserId;
            user.Name = UserName.Name;
            user.LastName = UserName.LastName;
            user.Phone = DbUsers.PhoneNumber;
            user.Email = DbUsers.Email;
            user.Status = UserName.Status;

            ListChangesWorkPlanViewModel model = new ListChangesWorkPlanViewModel();
            model.listChangesWorkPlan = _appDBContent.ChangesWorkPlan.Where(s => s.EmailTeacher == DbUsers.Email).ToList();
            model.userModel = user;
            return View(model);
        }

        [HttpGet]
        public IActionResult Back(int id)
        {
            return RedirectToAction("TeacherLayoutForManager", "Manager", new { id = id });
        }

        [HttpPost]
        public IActionResult SetCorrectUser(int id)
        {
            var element = _appDBContent.UserNames.Where(s => s.DbUserId == id).FirstOrDefault();
            var emailElement = _userManager.Users.Where(s => s.Id == id).FirstOrDefault();
            if (element.Status)
            {
                element.Status = false;
            }
            else
            {
                element.Status = true;
                string html = "Доброго дня! Ваш план затверджено, дякую за роботу.";
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("managerkafedra@gmail.com"));
                message.To.Add(new MailboxAddress(emailElement.Email));
                message.Subject = "Нове повідомлення";

                message.Body = new TextPart("plain")
                {
                    Text = html
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("managerkafedra@gmail.com", "qwerty-0");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            _appDBContent.SaveChanges();
            return RedirectToAction("AllTeacherTable");
        }

        [HttpGet]
        public IActionResult SetNotCorrectUser(int id)
        {
            EmailMessageViewModel model = new EmailMessageViewModel();
            model.Id = id;
            model.Email = _userManager.Users.Where(s => s.Id == id).FirstOrDefault().Email;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetNotCorrectUser(EmailMessageViewModel model)
        {
            var element = _appDBContent.UserNames.Where(s => s.DbUserId == model.Id).FirstOrDefault();
            element.Status = false;
            string html = model.Message;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("managerkafedra@gmail.com"));
            message.To.Add(new MailboxAddress(model.Email));
            message.Subject = "Нове повідомлення";

            message.Body = new TextPart("plain")
            {
                Text = html
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("managerkafedra@gmail.com", "qwerty-0");
                client.Send(message);
                client.Disconnect(true);

            }
            _appDBContent.SaveChanges();
            return RedirectToAction("AllTeacherTable");
        }

        [HttpGet]
        public IActionResult SetComment(int id)
        {
            EmailMessageViewModel model = new EmailMessageViewModel();
            model.Id = id;
            model.Email = _userManager.Users.Where(s => s.Id == id).FirstOrDefault().Email;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetComment(EmailMessageViewModel model)
        {
            var element = _appDBContent.UserNames.Where(s => s.DbUserId == model.Id).FirstOrDefault();
            string html = model.Message;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("managerkafedra@gmail.com"));
            message.To.Add(new MailboxAddress(model.Email));
            message.Subject = "Нове повідомлення";

            message.Body = new TextPart("plain")
            {
                Text = html
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("managerkafedra@gmail.com", "qwerty-0");
                client.Send(message);
                client.Disconnect(true);

            }
            _appDBContent.SaveChanges();
            return RedirectToAction("TeacherLayoutForManager", "Manager", new { id = model.Id });
        }
    }
}

