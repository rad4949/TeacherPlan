using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Plan.Data.Entities;
using Plan.intereces;
using Plan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        private readonly IRepository _repository;
        private readonly AppDBContent _appDBContent;
        public TeacherController(AppDBContent appDBContent, IRepository groups1)
        {
            this._appDBContent = appDBContent;
            this._repository = groups1;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CharacteristicGroupsTable1()
        {
            ListCharacteristicGrups1ViewModel model = new ListCharacteristicGrups1ViewModel();
            model.listCharacteristicGpoups = _appDBContent.Characteristic1Semestr.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        public IActionResult CharacteristicGroupsTable2()
        {
            ListCharacteristicGrups2ViewModel model = new ListCharacteristicGrups2ViewModel();
            model.listCharacteristicGpoups = _appDBContent.Characteristic2Semestr.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectCharacteristic1(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }

            int pageSize = 10;
            int pageNo = page - 1;

            model.listNameSubject = query.OrderBy(x => x.Id)
                .OrderBy(o => o.NameSubjects)
                .Skip(pageNo * pageSize)
                .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();

            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectCharacteristic2(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;
            int pageNo = page - 1;
            model.listNameSubject = query.OrderBy(x => x.Id)
                  .OrderBy(o => o.NameSubjects)
                  .Skip(pageNo * pageSize)
                  .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();
            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult SetCharacteristic1(int id)
        {
            CharacteristicGrupsViewModel model = new CharacteristicGrupsViewModel();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetCharacteristic1(CharacteristicGrupsViewModel grups1)
        {
            if (ModelState.IsValid)
            {
                _repository.createCharacteristicGroups1(grups1, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(grups1);
            }
        }

        [HttpGet]
        public IActionResult SetCharacteristic2(int id)
        {
            CharacteristicGrupsViewModel model = new CharacteristicGrupsViewModel();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetCharacteristic2(CharacteristicGrupsViewModel grups2)
        {
            if (ModelState.IsValid)
            {
                _repository.createCharacteristicGroups2(grups2, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(grups2);
            }
        }

        public IActionResult LectureClassesTable1()
        {
            ListLectureClasses1ViewModel model = new ListLectureClasses1ViewModel();
            model.listLectureClasses = _appDBContent.LectureClassesSemestr1.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        public IActionResult LectureClassesTable2()
        {
            ListLectureClasses2ViewModel model = new ListLectureClasses2ViewModel();
            model.listLectureClasses = _appDBContent.LectureClassesSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectLectureClasses1(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;
            int pageNo = page - 1;
            model.listNameSubject = query.OrderBy(x => x.Id)
                .OrderBy(o => o.NameSubjects)
                .Skip(pageNo * pageSize)
                .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();
            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectLectureClasses2(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;
            int pageNo = page - 1;
            model.listNameSubject = query.OrderBy(x => x.Id)
                 .OrderBy(o => o.NameSubjects)
                 .Skip(pageNo * pageSize)
                 .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();
            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult SetLectureClassesTable1(int id)
        {
            LectureClassesViewModel model = new LectureClassesViewModel();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetLectureClassesTable1(LectureClassesViewModel lectureClasses)
        {
            if (ModelState.IsValid)
            {
                _repository.createLectureClasses1(lectureClasses, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(lectureClasses);
            }
        }

        [HttpGet]
        public IActionResult SetLectureClassesTable2(int id)
        {
            LectureClassesViewModel model = new LectureClassesViewModel();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetLectureClassesTable2(LectureClassesViewModel lectureClasses)
        {
            if (ModelState.IsValid)
            {
                _repository.createLectureClasses2(lectureClasses, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(lectureClasses);
            }
        }

        [HttpGet]
        public IActionResult LectureClassesTableSum()
        {
            ListLectureClassesSumViewModel model = new ListLectureClassesSumViewModel();
            ListLectureClasses1ViewModel listSemestr1 = new ListLectureClasses1ViewModel();
            ListLectureClasses2ViewModel listSemestr2 = new ListLectureClasses2ViewModel();

            LectureClassesTableSemestr1 sem1 = new LectureClassesTableSemestr1();
            LectureClassesTableSemestr1 sem2 = new LectureClassesTableSemestr1();
            LectureClassesTableSemestr1 all = new LectureClassesTableSemestr1();

            listSemestr1.listLectureClasses = _appDBContent.LectureClassesSemestr1.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            listSemestr2.listLectureClasses = _appDBContent.LectureClassesSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            return View(model);
        }

        [HttpGet]
        public IActionResult ControlMeasuresTable1()
        {
            ListControlMeasuresViewModelsSemestr1 model = new ListControlMeasuresViewModelsSemestr1();
            model.listControlMeasures = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult ControlMeasuresTable2()
        {
            ListControlMeasuresViewModelsSemestr2 model = new ListControlMeasuresViewModelsSemestr2();
            model.listControlMeasures = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectControlMeasures1(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;
            int pageNo = page - 1;
            model.listNameSubject = query.OrderBy(x => x.Id)
                 .OrderBy(o => o.NameSubjects)
                 .Skip(pageNo * pageSize)
                 .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();
            int allCount = query.Count();
            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult NameSubjectControlMeasures2(Filter filter, int page = 1)
        {
            ListNameSubjectViewModel model = new ListNameSubjectViewModel();
            var query = _appDBContent.NameSubject.AsQueryable();
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.NameSubjects.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;
            int pageNo = page - 1;
            model.listNameSubject = query.OrderBy(x => x.Id)
                 .OrderBy(o => o.NameSubjects)
                 .Skip(pageNo * pageSize)
                 .ToList();

            model.listNameSubject = model.listNameSubject
                .Take(pageSize)
                .ToList();
            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }

        [HttpGet]
        public IActionResult SetControlMeasuresTable1(int id)
        {
            ControlMeasuresViewModels model = new ControlMeasuresViewModels();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetControlMeasuresTable1(ControlMeasuresViewModels lectureClasses)
        {
            if (ModelState.IsValid)
            {
                _repository.createControlMeasures1(lectureClasses, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(lectureClasses);
            }
        }

        [HttpGet]
        public IActionResult SetControlMeasuresTable2(int id)
        {
            ControlMeasuresViewModels model = new ControlMeasuresViewModels();
            model.NameAcademiDisciplines = _appDBContent.NameSubject.Where(s => s.Id == id).FirstOrDefault().NameSubjects;
            return View(model);
        }

        [HttpPost]
        public IActionResult SetControlMeasuresTable2(ControlMeasuresViewModels lectureClasses)
        {
            if (ModelState.IsValid)
            {
                _repository.createControlMeasures2(lectureClasses, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(lectureClasses);
            }
        }

        [HttpGet]
        public IActionResult ControlMeasuresSum()
        {
            ListSumControlMeasuresViewModels model = new ListSumControlMeasuresViewModels();
            ListControlMeasuresViewModelsSemestr1 listSemestr1 = new ListControlMeasuresViewModelsSemestr1();
            ListControlMeasuresViewModelsSemestr2 listSemestr2 = new ListControlMeasuresViewModelsSemestr2();

            ControlMeasuresSemestr1 sem1 = new ControlMeasuresSemestr1();
            ControlMeasuresSemestr1 sem2 = new ControlMeasuresSemestr1();
            ControlMeasuresSemestr1 all = new ControlMeasuresSemestr1();

            listSemestr1.listControlMeasures = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            listSemestr2.listControlMeasures = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            return View(model);
        }

        [HttpGet]
        public IActionResult MethodicalWorkTable()
        {
            ListMethodicalWorkViewModel model = new ListMethodicalWorkViewModel();
            model.methodicalWorks = _appDBContent.MethodicalWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetMethodicalWorkTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetMethodicalWorkTable(MethodicalWorkViewModel methodical)
        {
            if (ModelState.IsValid)
            {
                _repository.createMethodicalWork(methodical, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(methodical);
            }
        }

        [HttpPost]
        public IActionResult SetCorrectMethodicalWork(int id)
        {
            var element = _appDBContent.MethodicalWork.Where(s => s.Id == id).FirstOrDefault();
            if (element.Correct)
            {
                element.Correct = false;
            }
            else
            {
                element.Correct = true;
            }
            _appDBContent.SaveChanges();
            return RedirectToAction("MethodicalWorkTable");
        }

        [HttpGet]
        public IActionResult ScientificWorkTable()
        {
            ListScientificWorkViewModel model = new ListScientificWorkViewModel();
            model.scientificWorks = _appDBContent.ScientificWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetScientificWorkTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetScientificWorkTable(ScientificWorkViewModel scientific)
        {
            if (ModelState.IsValid)
            {
                _repository.createScientificWork(scientific, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(scientific);
            }
        }

        [HttpPost]
        public IActionResult SetCorrectSetScientificWork(int id)
        {
            var element = _appDBContent.ScientificWork.Where(s => s.Id == id).FirstOrDefault();
            if (element.Correct)
            {
                element.Correct = false;
            }
            else
            {
                element.Correct = true;
            }
            _appDBContent.SaveChanges();
            return RedirectToAction("ScientificWorkTable");
        }

        [HttpGet]
        public IActionResult OrganizationalWorkTable()
        {
            ListOrganizationalWorkViewModel model = new ListOrganizationalWorkViewModel();
            model.organizationalWorks = _appDBContent.OrganizationalWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetOrganizationalWorkTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetOrganizationalWorkTable(OrganizationalWorkViewModel organizational)
        {
            if (ModelState.IsValid)
            {
                _repository.createOrganizationalWork(organizational, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(organizational);
            }
        }

        [HttpPost]
        public IActionResult SetCorrectOrganizationalWork(int id)
        {
            var element = _appDBContent.OrganizationalWork.Where(s => s.Id == id).FirstOrDefault();
            if (element.Correct)
            {
                element.Correct = false;
            }
            else
            {
                element.Correct = true;
            }
            _appDBContent.SaveChanges();
            return RedirectToAction("OrganizationalWorkTable");
        }

        [HttpGet]
        public IActionResult EducationalActivitiesTable()
        {
            ListEducationalActivitiesViewModel model = new ListEducationalActivitiesViewModel();
            model.educationalActivities = _appDBContent.EducationalActivities.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetEducationalActivitiesTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetEducationalActivitiesTable(EducationalActivitiesViewModel educational)
        {
            if (ModelState.IsValid)
            {
                _repository.createEducationalActivities(educational, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(educational);
            }
        }

        [HttpPost]
        public IActionResult SetCorrectEducationalActivities(int id)
        {
            var element = _appDBContent.EducationalActivities.Where(s => s.Id == id).FirstOrDefault();
            if (element.Correct)
            {
                element.Correct = false;
            }
            else
            {
                element.Correct = true;
            }
            _appDBContent.SaveChanges();
            return RedirectToAction("EducationalActivitiesTable");
        }

        [HttpGet]
        public IActionResult ChangesWorkPlanTable()
        {
            ListChangesWorkPlanViewModel model = new ListChangesWorkPlanViewModel();
            model.listChangesWorkPlan = _appDBContent.ChangesWorkPlan.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetChangesWorkPlanTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetChangesWorkPlanTable(ChangesWorkPlanViewModel changes)
        {
            if (ModelState.IsValid)
            {
                _repository.createChangesWorkPlan(changes, User.Identity.Name);
                return RedirectToAction("Complete");
            }
            else
            {
                return View(changes);
            }
        }

        [HttpGet]
        public IActionResult OtherTypesWorkTable()
        {
            ListOtherTypesWorkViewModel model = new ListOtherTypesWorkViewModel();
            model.otherTypesWorks = _appDBContent.OtherTypesWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            model.otherTypesWorks = model.otherTypesWorks.OrderBy(o => o.ColumId).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetOtherTypesWorkTable(int Id)
        {
            OtherTypesWork element = _appDBContent.OtherTypesWork.Where(s => s.Id == Id
            && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
            OtherTypesWorkViewModel otherTypes = new OtherTypesWorkViewModel();
            otherTypes.Id = element.Id;
            otherTypes.Faculty = element.Faculty;
            otherTypes.Course = element.Course;
            otherTypes.CodeGrup = element.CodeGrup;
            otherTypes.CountStudentsBud = element.CountStudentsBud;
            otherTypes.CountStudentsCon = element.CountStudentsCon;
            otherTypes.HoursBudPl = element.HoursBudPl;
            otherTypes.HoursBudVuc = element.HoursBudVuc;
            otherTypes.HoursConPl = element.HoursConPl;
            otherTypes.HoursConVuc = element.HoursConVuc;
            otherTypes.ColumId = element.ColumId;
            return View(otherTypes);
        }

        [HttpPost]
        public IActionResult SetOtherTypesWorkTable(OtherTypesWorkViewModel other)
        {
            if (ModelState.IsValid)
            {
                var element = _appDBContent.OtherTypesWork.Where(s => s.Id == other.Id
                && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
                var sumElement = _appDBContent.OtherTypesWork.Where(s => s.ColumId == 34
                && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
                List<OtherTypesWork> listOtherTypes = new List<OtherTypesWork>();
                listOtherTypes = _appDBContent.OtherTypesWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();

                if (element.ColumId <= 2)
                {
                    element.Course = 1;
                    if (element.ColumId == 2)
                    {
                        element.Course = 2;
                    }
                }
                else
                {
                    element.Course = other.Course;
                }

                element.Faculty = other.Faculty;
                element.CodeGrup = other.CodeGrup;
                element.CountStudentsBud = other.CountStudentsBud;
                element.CountStudentsCon = other.CountStudentsCon;
                element.HoursBudPl = other.HoursBudPl;
                element.HoursBudVuc = other.HoursBudVuc;
                element.HoursConPl = other.HoursConPl;
                element.HoursConVuc = other.HoursConVuc;
                _appDBContent.SaveChanges();

                sumElement.CountStudentsBud = 0;
                sumElement.CountStudentsCon = 0;
                sumElement.HoursBudPl = 0;
                sumElement.HoursBudVuc = 0;
                sumElement.HoursConPl = 0;
                sumElement.HoursConVuc = 0;
                foreach (var item in listOtherTypes)
                {
                    if (sumElement.Id != item.Id)
                    {
                        sumElement.CountStudentsBud += item.CountStudentsBud;
                        sumElement.CountStudentsCon += item.CountStudentsCon;
                        sumElement.HoursBudPl += item.HoursBudPl;
                        sumElement.HoursBudVuc += item.HoursBudVuc;
                        sumElement.HoursConPl += item.HoursConPl;
                        sumElement.HoursConVuc += item.HoursConVuc;
                    }
                }
                _appDBContent.SaveChanges();
                return RedirectToAction("OtherTypesWorkTable");
            }
            else
            {
                return View(other);
            }
        }

        [HttpGet]
        public IActionResult OtherTypesWorkSemestr2Table()
        {
            ListOtherTypesWorkSemestr2ViewModel model = new ListOtherTypesWorkSemestr2ViewModel();
            model.otherTypesWorks = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            model.otherTypesWorks = model.otherTypesWorks.OrderBy(o => o.ColumId).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult SetOtherTypesWorkSemestr2Table(int Id)
        {
            OtherTypesWorkSemestr2 element = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.Id == Id
            && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
            OtherTypesWorkViewModel otherTypes = new OtherTypesWorkViewModel();
            otherTypes.Id = element.Id;
            otherTypes.Faculty = element.Faculty;
            otherTypes.Course = element.Course;
            otherTypes.CodeGrup = element.CodeGrup;
            otherTypes.CountStudentsBud = element.CountStudentsBud;
            otherTypes.CountStudentsCon = element.CountStudentsCon;
            otherTypes.HoursBudPl = element.HoursBudPl;
            otherTypes.HoursBudVuc = element.HoursBudVuc;
            otherTypes.HoursConPl = element.HoursConPl;
            otherTypes.HoursConVuc = element.HoursConVuc;
            otherTypes.ColumId = element.ColumId;
            return View(otherTypes);
        }

        [HttpPost]
        public IActionResult SetOtherTypesWorkSemestr2Table(OtherTypesWorkViewModel other)
        {
            if (ModelState.IsValid)
            {
                var element = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.Id == other.Id
                && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
                var sumElement = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.ColumId == 34
                && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
                List<OtherTypesWorkSemestr2> listOtherTypes = new List<OtherTypesWorkSemestr2>();
                listOtherTypes = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();

                if (element.Id <= 2)
                {
                    element.Course = 1;
                    if (element.Id == 2)
                    {
                        element.Course = 2;
                    }
                }
                else
                {
                    element.Course = other.Course;
                }

                element.Faculty = other.Faculty;
                element.CodeGrup = other.CodeGrup;
                element.CountStudentsBud = other.CountStudentsBud;
                element.CountStudentsCon = other.CountStudentsCon;
                element.HoursBudPl = other.HoursBudPl;
                element.HoursBudVuc = other.HoursBudVuc;
                element.HoursConPl = other.HoursConPl;
                element.HoursConVuc = other.HoursConVuc;
                _appDBContent.SaveChanges();

                sumElement.CountStudentsBud = 0;
                sumElement.CountStudentsCon = 0;
                sumElement.HoursBudPl = 0;
                sumElement.HoursBudVuc = 0;
                sumElement.HoursConPl = 0;
                sumElement.HoursConVuc = 0;
                foreach (var item in listOtherTypes)
                {
                    if (sumElement.Id != item.Id)
                    {
                        sumElement.CountStudentsBud += item.CountStudentsBud;
                        sumElement.CountStudentsCon += item.CountStudentsCon;
                        sumElement.HoursBudPl += item.HoursBudPl;
                        sumElement.HoursBudVuc += item.HoursBudVuc;
                        sumElement.HoursConPl += item.HoursConPl;
                        sumElement.HoursConVuc += item.HoursConVuc;
                    }
                }
                _appDBContent.SaveChanges();
                return RedirectToAction("OtherTypesWorkSemestr2Table");
            }
            else
            {
                return View(other);
            }
        }

        [HttpGet]
        public IActionResult WorkloadSum()
        {
            var firstSemestr = _appDBContent.WorkloadSum.Where(s => s.ColumId == 1
            && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
            List<ControlMeasuresSemestr1> controlMeasures1 = new List<ControlMeasuresSemestr1>();
            controlMeasures1 = _appDBContent.ControlSemestr1.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            otherTypes1 = _appDBContent.OtherTypesWork.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
            List<ControlMeasuresSemestr2> controlMeasures2 = new List<ControlMeasuresSemestr2>();
            controlMeasures2 = _appDBContent.ControlSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            otherTypes2 = _appDBContent.OtherTypesWorkSemestr2.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            && s.EmailTeacher == User.Identity.Name).FirstOrDefault();
            List<WorkloadSum> workloadSums = _appDBContent.WorkloadSum.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
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
            workloadSumViewModel.listWorkloadSum = _appDBContent.WorkloadSum.Where(s => s.EmailTeacher == User.Identity.Name).ToList();
            workloadSumViewModel.listWorkloadSum = workloadSumViewModel.listWorkloadSum.OrderBy(o => o.ColumId).ToList();
            return View(workloadSumViewModel);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Створення успішно виконано";
            return View();
        }
    }
}
