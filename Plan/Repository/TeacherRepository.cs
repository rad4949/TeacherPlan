using Microsoft.AspNetCore.Mvc;
using Plan.Data.Entities;
using Plan.intereces;
using Plan.Models;
using Plan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Repository
{
    public class TeacherRepository : Controller, IRepository
    {
        private readonly AppDBContent _appDBContent;
        public TeacherRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public void createCharacteristicGroups1(CharacteristicGrupsViewModel characteristicGrups1, string EmailTeacher)
        {
            CharacteristicGroupsSemestr1 characteristic11 = new CharacteristicGroupsSemestr1();
            characteristic11.NameAcademiDisciplines = characteristicGrups1.NameAcademiDisciplines;
            characteristic11.CountDisciplinesSemester = characteristicGrups1.CountDisciplinesSemester;
            characteristic11.Faculty = characteristicGrups1.Faculty;
            characteristic11.Curriculum = characteristicGrups1.Curriculum;
            characteristic11.AcademiсGroupsBud = characteristicGrups1.AcademiсGroupsBud;
            characteristic11.PracticalLessonBud = characteristicGrups1.PracticalLessonBud;
            characteristic11.LabLessonBud = characteristicGrups1.LabLessonBud;
            characteristic11.AcademicGroupsCon = characteristicGrups1.AcademicGroupsCon;
            characteristic11.PracticalLessonCon = characteristicGrups1.PracticalLessonCon;
            characteristic11.LabLessonCon = characteristicGrups1.LabLessonCon;
            characteristic11.CodeGrup = characteristicGrups1.CodeGrup;
            characteristic11.CountStudentsBud = characteristicGrups1.CountStudentsBud;
            characteristic11.CountStudentsCon = characteristicGrups1.CountStudentsCon;
            characteristic11.CountStreamsBud = characteristicGrups1.CountStreamsBud;
            characteristic11.CountStreamsCon = characteristicGrups1.CountStreamsCon;
            characteristic11.EmailTeacher = EmailTeacher;

            _appDBContent.Characteristic1Semestr.Add(characteristic11);
            _appDBContent.SaveChanges();
        }

        public void createCharacteristicGroups2(CharacteristicGrupsViewModel characteristicGrups2, string EmailTeacher)
        {
            CharacteristicGroupsSemestr2 characteristic11 = new CharacteristicGroupsSemestr2();
            characteristic11.NameAcademiDisciplines = characteristicGrups2.NameAcademiDisciplines;
            characteristic11.CountDisciplinesSemester = characteristicGrups2.CountDisciplinesSemester;
            characteristic11.Faculty = characteristicGrups2.Faculty;
            characteristic11.Curriculum = characteristicGrups2.Curriculum;
            characteristic11.AcademiсGroupsBud = characteristicGrups2.AcademiсGroupsBud;
            characteristic11.PracticalLessonBud = characteristicGrups2.PracticalLessonBud;
            characteristic11.LabLessonBud = characteristicGrups2.LabLessonBud;
            characteristic11.AcademicGroupsCon = characteristicGrups2.AcademicGroupsCon;
            characteristic11.PracticalLessonCon = characteristicGrups2.PracticalLessonCon;
            characteristic11.LabLessonCon = characteristicGrups2.LabLessonCon;
            characteristic11.CodeGrup = characteristicGrups2.CodeGrup;
            characteristic11.CountStudentsBud = characteristicGrups2.CountStudentsBud;
            characteristic11.CountStudentsCon = characteristicGrups2.CountStudentsCon;
            characteristic11.CountStreamsBud = characteristicGrups2.CountStreamsBud;
            characteristic11.CountStreamsCon = characteristicGrups2.CountStreamsCon;
            characteristic11.EmailTeacher = EmailTeacher;

            _appDBContent.Characteristic2Semestr.Add(characteristic11);
            _appDBContent.SaveChanges();
        }

        public void createLectureClasses1(LectureClassesViewModel lectureClasses, string EmailTeacher)
        {
            LectureClassesTableSemestr1 lectureClassesFinish = new LectureClassesTableSemestr1();
            lectureClassesFinish.NameAcademiDisciplines = lectureClasses.NameAcademiDisciplines;

            lectureClassesFinish.LectureBudPl = lectureClasses.LectureBudPl;
            lectureClassesFinish.LectureBudVuc = lectureClasses.LectureBudVuc;
            lectureClassesFinish.LectureConPl = lectureClasses.LectureConPl;
            lectureClassesFinish.LectureConVuc = lectureClasses.LectureConVuc;

            lectureClassesFinish.PractBudPl = lectureClasses.PractBudPl;
            lectureClassesFinish.PractBudVuc = lectureClasses.PractBudVuc;
            lectureClassesFinish.PractConPl = lectureClasses.PractConPl;
            lectureClassesFinish.PractConVuc = lectureClasses.PractConVuc;

            lectureClassesFinish.LabBudPl = lectureClasses.LabBudPl;
            lectureClassesFinish.LabBudVuc = lectureClasses.LabBudVuc;
            lectureClassesFinish.LabConPl = lectureClasses.LabConPl;
            lectureClassesFinish.LabConVuc = lectureClasses.LabConVuc;

            lectureClassesFinish.IndBudPl = lectureClasses.IndBudPl;
            lectureClassesFinish.IndBudVuc = lectureClasses.IndBudVuc;
            lectureClassesFinish.IndConPl = lectureClasses.IndConPl;
            lectureClassesFinish.IndConVuc = lectureClasses.IndConVuc;

            lectureClassesFinish.EmailTeacher = EmailTeacher;

            _appDBContent.LectureClassesSemestr1.Add(lectureClassesFinish);
            _appDBContent.SaveChanges();
        }

        public void createLectureClasses2(LectureClassesViewModel lectureClasses, string EmailTeacher)
        {
            LectureClassesTableSemestr2 lectureClassesFinish = new LectureClassesTableSemestr2();
            lectureClassesFinish.NameAcademiDisciplines = lectureClasses.NameAcademiDisciplines;

            lectureClassesFinish.LectureBudPl = lectureClasses.LectureBudPl;
            lectureClassesFinish.LectureBudVuc = lectureClasses.LectureBudVuc;
            lectureClassesFinish.LectureConPl = lectureClasses.LectureConPl;
            lectureClassesFinish.LectureConVuc = lectureClasses.LectureConVuc;

            lectureClassesFinish.PractBudPl = lectureClasses.PractBudPl;
            lectureClassesFinish.PractBudVuc = lectureClasses.PractBudVuc;
            lectureClassesFinish.PractConPl = lectureClasses.PractConPl;
            lectureClassesFinish.PractConVuc = lectureClasses.PractConVuc;

            lectureClassesFinish.LabBudPl = lectureClasses.LabBudPl;
            lectureClassesFinish.LabBudVuc = lectureClasses.LabBudVuc;
            lectureClassesFinish.LabConPl = lectureClasses.LabConPl;
            lectureClassesFinish.LabConVuc = lectureClasses.LabConVuc;

            lectureClassesFinish.IndBudPl = lectureClasses.IndBudPl;
            lectureClassesFinish.IndBudVuc = lectureClasses.IndBudVuc;
            lectureClassesFinish.IndConPl = lectureClasses.IndConPl;
            lectureClassesFinish.IndConVuc = lectureClasses.IndConVuc;

            lectureClassesFinish.EmailTeacher = EmailTeacher;

            _appDBContent.LectureClassesSemestr2.Add(lectureClassesFinish);
            _appDBContent.SaveChanges();
        }

        public void createControlMeasures1(ControlMeasuresViewModels controlMeasures, string EmailTeacher)
        {
            ControlMeasuresSemestr1 measuresSemestr = new ControlMeasuresSemestr1();

            measuresSemestr.NameAcademiDisciplines = controlMeasures.NameAcademiDisciplines;

            measuresSemestr.ExamBudPl = controlMeasures.ExamBudPl;
            measuresSemestr.ExamBudVuc = controlMeasures.ExamBudVuc;
            measuresSemestr.ExamConPl = controlMeasures.ExamConPl;
            measuresSemestr.ExamConVuc = controlMeasures.ExamConVuc;

            measuresSemestr.TestBudPl = controlMeasures.TestBudPl;
            measuresSemestr.TestBudVuc = controlMeasures.TestBudVuc;
            measuresSemestr.TestConPl = controlMeasures.TestConPl;
            measuresSemestr.TestConVuc = controlMeasures.TestConVuc;

            measuresSemestr.KRBudPl = controlMeasures.KRBudPl;
            measuresSemestr.KRBudVuc = controlMeasures.KRBudVuc;
            measuresSemestr.KRConPl = controlMeasures.KRConPl;
            measuresSemestr.KRConVuc = controlMeasures.KRConVuc;

            measuresSemestr.CursRobBudPl = controlMeasures.CursRobBudPl;
            measuresSemestr.CursRobBudVuc = controlMeasures.CursRobBudVuc;
            measuresSemestr.CursRobConPl = controlMeasures.CursRobConPl;
            measuresSemestr.CursRobConVuc = controlMeasures.CursRobConVuc;

            measuresSemestr.CursProectBudPl = controlMeasures.CursProectBudPl;
            measuresSemestr.CursProectBudVuc = controlMeasures.CursProectBudVuc;
            measuresSemestr.CursProectConPl = controlMeasures.CursProectConPl;
            measuresSemestr.CursProectConVuc = controlMeasures.CursProectConVuc;

            measuresSemestr.RGRBudPl = controlMeasures.RGRBudPl;
            measuresSemestr.RGRBudVuc = controlMeasures.RGRBudVuc;
            measuresSemestr.RGRConPl = controlMeasures.RGRConPl;
            measuresSemestr.RGRConVuc = controlMeasures.RGRConVuc;

            measuresSemestr.DKRBudPl = controlMeasures.DKRBudPl;
            measuresSemestr.DKRBudVuc = controlMeasures.DKRBudVuc;
            measuresSemestr.DKRConPl = controlMeasures.DKRConPl;
            measuresSemestr.DKRConVuc = controlMeasures.DKRConVuc;

            measuresSemestr.AbstractBudPl = controlMeasures.AbstractBudPl;
            measuresSemestr.AbstractBudVuc = controlMeasures.AbstractBudVuc;
            measuresSemestr.AbstractConPl = controlMeasures.AbstractConPl;
            measuresSemestr.AbstractConVuc = controlMeasures.AbstractConVuc;

            measuresSemestr.CosultationBudPl = controlMeasures.CosultationBudPl;
            measuresSemestr.CosultationBudVuc = controlMeasures.CosultationBudVuc;
            measuresSemestr.CosultationConPl = controlMeasures.CosultationConPl;
            measuresSemestr.CosultationConVuc = controlMeasures.CosultationConVuc;

            measuresSemestr.EmailTeacher = EmailTeacher;

            _appDBContent.ControlSemestr1.Add(measuresSemestr);
            _appDBContent.SaveChanges();
        }

        public void createControlMeasures2(ControlMeasuresViewModels controlMeasures, string EmailTeacher)
        {
            ControlMeasuresSemestr2 measuresSemestr = new ControlMeasuresSemestr2();

            measuresSemestr.NameAcademiDisciplines = controlMeasures.NameAcademiDisciplines;

            measuresSemestr.ExamBudPl = controlMeasures.ExamBudPl;
            measuresSemestr.ExamBudVuc = controlMeasures.ExamBudVuc;
            measuresSemestr.ExamConPl = controlMeasures.ExamConPl;
            measuresSemestr.ExamConVuc = controlMeasures.ExamConVuc;

            measuresSemestr.TestBudPl = controlMeasures.TestBudPl;
            measuresSemestr.TestBudVuc = controlMeasures.TestBudVuc;
            measuresSemestr.TestConPl = controlMeasures.TestConPl;
            measuresSemestr.TestConVuc = controlMeasures.TestConVuc;

            measuresSemestr.KRBudPl = controlMeasures.KRBudPl;
            measuresSemestr.KRBudVuc = controlMeasures.KRBudVuc;
            measuresSemestr.KRConPl = controlMeasures.KRConPl;
            measuresSemestr.KRConVuc = controlMeasures.KRConVuc;

            measuresSemestr.CursRobBudPl = controlMeasures.CursRobBudPl;
            measuresSemestr.CursRobBudVuc = controlMeasures.CursRobBudVuc;
            measuresSemestr.CursRobConPl = controlMeasures.CursRobConPl;
            measuresSemestr.CursRobConVuc = controlMeasures.CursRobConVuc;

            measuresSemestr.CursProectBudPl = controlMeasures.CursProectBudPl;
            measuresSemestr.CursProectBudVuc = controlMeasures.CursProectBudVuc;
            measuresSemestr.CursProectConPl = controlMeasures.CursProectConPl;
            measuresSemestr.CursProectConVuc = controlMeasures.CursProectConVuc;

            measuresSemestr.RGRBudPl = controlMeasures.RGRBudPl;
            measuresSemestr.RGRBudVuc = controlMeasures.RGRBudVuc;
            measuresSemestr.RGRConPl = controlMeasures.RGRConPl;
            measuresSemestr.RGRConVuc = controlMeasures.RGRConVuc;

            measuresSemestr.DKRBudPl = controlMeasures.DKRBudPl;
            measuresSemestr.DKRBudVuc = controlMeasures.DKRBudVuc;
            measuresSemestr.DKRConPl = controlMeasures.DKRConPl;
            measuresSemestr.DKRConVuc = controlMeasures.DKRConVuc;

            measuresSemestr.AbstractBudPl = controlMeasures.AbstractBudPl;
            measuresSemestr.AbstractBudVuc = controlMeasures.AbstractBudVuc;
            measuresSemestr.AbstractConPl = controlMeasures.AbstractConPl;
            measuresSemestr.AbstractConVuc = controlMeasures.AbstractConVuc;

            measuresSemestr.CosultationBudPl = controlMeasures.CosultationBudPl;
            measuresSemestr.CosultationBudVuc = controlMeasures.CosultationBudVuc;
            measuresSemestr.CosultationConPl = controlMeasures.CosultationConPl;
            measuresSemestr.CosultationConVuc = controlMeasures.CosultationConVuc;

            measuresSemestr.EmailTeacher = EmailTeacher;

            _appDBContent.ControlSemestr2.Add(measuresSemestr);
            _appDBContent.SaveChanges();
        }

        public void createMethodicalWork(MethodicalWorkViewModel methodical, string EmailTeacher)
        {
            MethodicalWork methodicalWork = new MethodicalWork();
            methodicalWork.NameMethodicalWork = methodical.NameMethodicalWork;
            methodicalWork.DateSuccess = methodical.DateSuccess;
            methodicalWork.Correct = false;
            methodicalWork.EmailTeacher = EmailTeacher;

            _appDBContent.MethodicalWork.Add(methodicalWork);
            _appDBContent.SaveChanges();
        }

        public void createScientificWork(ScientificWorkViewModel scientific, string EmailTeacher)
        {
            ScientificWork scientificWork = new ScientificWork();
            scientificWork.NameScientificWork = scientific.NameScientificWork;
            scientificWork.DateSuccess = scientific.DateSuccess;
            scientificWork.Correct = false;
            scientificWork.EmailTeacher = EmailTeacher;

            _appDBContent.ScientificWork.Add(scientificWork);
            _appDBContent.SaveChanges();
        }

        public void createOrganizationalWork(OrganizationalWorkViewModel organizational, string EmailTeacher)
        {
            OrganizationalWork organizationalWork = new OrganizationalWork();
            organizationalWork.NameOrganizationalWork = organizational.NameOrganizationalWork;
            organizationalWork.DateSuccess = organizational.DateSuccess;
            organizationalWork.EmailTeacher = EmailTeacher;

            _appDBContent.OrganizationalWork.Add(organizationalWork);
            _appDBContent.SaveChanges();
        }

        public void createEducationalActivities(EducationalActivitiesViewModel educational, string EmailTeacher)
        {
            EducationalActivities educationalActivities = new EducationalActivities();
            educationalActivities.NameEducationalActivities = educational.NameEducationalActivities;
            educationalActivities.DateSuccess = educational.DateSuccess;
            educationalActivities.Correct = false;
            educationalActivities.EmailTeacher = EmailTeacher;

            _appDBContent.EducationalActivities.Add(educationalActivities);
            _appDBContent.SaveChanges();
        }

        public void createChangesWorkPlan(ChangesWorkPlanViewModel changes, string EmailTeacher)
        {
            ChangesWorkPlan changesWork = new ChangesWorkPlan();
            changesWork.NameChangesWorkPlan = changes.NameChangesWorkPlan;
            changesWork.CountReason = changes.CountReason;
            changesWork.ReasonChanges = changes.ReasonChanges;
            changesWork.EmailTeacher = EmailTeacher;

            _appDBContent.ChangesWorkPlan.Add(changesWork);
            _appDBContent.SaveChanges();
        }

        public async Task createOtherTypesWork1(string EmailTeacher)
        {
            List<OtherTypesWork> otherTypes = new List<OtherTypesWork>();
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Інд. заняття по дисц. \" Наукові дослідж.\" з магістрами",
                Faculty = "",
                Course = 1,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 1
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Інд. заняття по дисц. \" Наукові дослідж.\" з магістрами",
                Faculty = "",
                Course = 2,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 2
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво практикою (навчальною)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 3
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво практикою (виробничою)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 4
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво практикою (переддиплом)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 5
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 6
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 7
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 8
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 9
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 10
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 11
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 12
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 13
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 14
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. бакалаврів",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 15
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. магістрів ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 16
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. магістрів ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 17
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК захист дипл. бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 18
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 19
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 20
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК захист дисерт. магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 21
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 22
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 23
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК захист дисерт. магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 24
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 25
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 26
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Проведення вступних екзаменів бакалавр*",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 27
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Проведення вступних екзаменів магістр ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 28
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Проведення вступних екзаменів магістр ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 29
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Проведення вступних екзаменів аспірант",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 30
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво аспірантами",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 31
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Керівництво здобув. стаж",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 32
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Консультування докторів",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 33
            });
            otherTypes.Add(new OtherTypesWork
            {
                NameOtherTypesWork = "Всього",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 34
            });

            //foreach (var item in otherTypes)
            //{
            //    _appDBContent.OtherTypesWork.AddAsync(item);
            //    _appDBContent.SaveChangesAsync();
            //}
            await _appDBContent.OtherTypesWork.AddRangeAsync(otherTypes);
            await _appDBContent.SaveChangesAsync();

        }

        public async Task createOtherTypesWork2(string EmailTeacher)
        {
            List<OtherTypesWorkSemestr2> otherTypesSemestr2 = new List<OtherTypesWorkSemestr2>();
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Інд. заняття по дисц. \" Наукові дослідж.\" з магістрами",
                Faculty = "",
                Course = 1,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 1
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Інд. заняття по дисц. \" Наукові дослідж.\" з магістрами",
                Faculty = "",
                Course = 2,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 2
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво практикою (навчальною)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 3
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво практикою (виробничою)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 4
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво практикою (переддиплом)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 5
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 6
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 7
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 8
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 9
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 10
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 11
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (бакалаврів)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 12
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (магістрів ОПП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 13
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Рецензування атестац. робіт (магістрів ОНП)",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 14
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. бакалаврів",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 15
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. магістрів ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 16
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування перед випуск. екзам. магістрів ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 17
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК захист дипл. бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 18
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 19
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. бакалаври",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 20
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК захист дисерт. магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 21
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 22
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. магістри ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 23
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК захист дисерт. магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 24
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. усний магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 25
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Робота в ЕК екзам. письм. магістри ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 26
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Проведення вступних екзаменів бакалавр*",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 27
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Проведення вступних екзаменів магістр ОПП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 28
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Проведення вступних екзаменів магістр ОНП",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 29
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Проведення вступних екзаменів аспірант",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 30
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво аспірантами",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 31
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Керівництво здобув. стаж",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 32
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Консультування докторів",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 33
            });
            otherTypesSemestr2.Add(new OtherTypesWorkSemestr2
            {
                NameOtherTypesWork = "Всього",
                Faculty = "",
                Course = 0,
                CodeGrup = "",
                CountStudentsBud = 0,
                CountStudentsCon = 0,
                HoursBudPl = 0,
                HoursBudVuc = 0,
                HoursConPl = 0,
                HoursConVuc = 0,
                EmailTeacher = EmailTeacher,
                ColumId = 34
            });

            //foreach (var item in otherTypesSemestr2)
            //{
            //    _appDBContent.OtherTypesWorkSemestr2.AddAsync(item);
            //    _appDBContent.SaveChangesAsync();
            //}
            await _appDBContent.OtherTypesWorkSemestr2.AddRangeAsync(otherTypesSemestr2);
            await _appDBContent.SaveChangesAsync();

        }

        public async Task createWorkloadSum(string EmailTeacher)
        {
            List<WorkloadSum> workloadSums = new List<WorkloadSum>();

            workloadSums.Add(new WorkloadSum
            {
                NameWorkloadSum = "I семестр",
                TeachingBudPl = 0,
                TeachingBudVuc = 0,
                TeachingConPl = 0,
                TeachingConVuc = 0,

                OtherBudPl = 0,
                OtherBudVuc = 0,
                OtherConPl = 0,
                OtherConVuc = 0,

                AllBudPl = 0,
                AllBudVuc = 0,
                AllConPl = 0,
                AllConVuc = 0,

                ColumId = 1,
                EmailTeacher = EmailTeacher
            });
            workloadSums.Add(new WorkloadSum
            {
                NameWorkloadSum = "II семестр",
                TeachingBudPl = 0,
                TeachingBudVuc = 0,
                TeachingConPl = 0,
                TeachingConVuc = 0,

                OtherBudPl = 0,
                OtherBudVuc = 0,
                OtherConPl = 0,
                OtherConVuc = 0,

                AllBudPl = 0,
                AllBudVuc = 0,
                AllConPl = 0,
                AllConVuc = 0,
                ColumId = 2,
                EmailTeacher = EmailTeacher
            });
            workloadSums.Add(new WorkloadSum
            {
                NameWorkloadSum = "Разом за рік",
                TeachingBudPl = 0,
                TeachingBudVuc = 0,
                TeachingConPl = 0,
                TeachingConVuc = 0,

                OtherBudPl = 0,
                OtherBudVuc = 0,
                OtherConPl = 0,
                OtherConVuc = 0,

                AllBudPl = 0,
                AllBudVuc = 0,
                AllConPl = 0,
                AllConVuc = 0,

                ColumId = 3,
                EmailTeacher = EmailTeacher
            });

            //foreach (var item in workloadSums)
            //{
            //    _appDBContent.WorkloadSum.AddAsync(item);
            //    _appDBContent.SaveChangesAsync();
            //}
            await _appDBContent.WorkloadSum.AddRangeAsync(workloadSums);
            await _appDBContent.SaveChangesAsync();

        }

        public async Task createUserNames(UserNameModel userNameModel)
        {
            UserNames userNames = new UserNames();
            userNames.DbUserId = userNameModel.DbUserId;
            userNames.Name = userNameModel.Name;
            userNames.LastName = userNameModel.LastName;
            userNames.Status = false;

            await _appDBContent.UserNames.AddAsync(userNames);
            await _appDBContent.SaveChangesAsync();
        }
    }
}
