using System;
using System.Collections.Generic;
using System.Linq;
using Plan.Data.Entities;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class SeederDB
    {
        public static void Initial(AppDBContent content)
        {
            List<CharacteristicGroupsSemestr1> characteristicGroups1list = new List<CharacteristicGroupsSemestr1>
            {
                new CharacteristicGroupsSemestr1
                {
                    NameAcademiDisciplines="Вища математика",
                    CountDisciplinesSemester=2,
                    Faculty="ТЕФ",
                    Curriculum=2,
                    AcademiсGroupsBud=2,
                    PracticalLessonBud=3,
                    LabLessonBud=2,
                    AcademicGroupsCon=4,
                    PracticalLessonCon=1,
                    LabLessonCon=2,
                    CodeGrup="ТІ-82",
                    CountStudentsBud=70,
                    CountStudentsCon=10,
                    CountStreamsBud=3,
                    CountStreamsCon=1,
                    EmailTeacher="teacher@gmail.com"
                },
                new CharacteristicGroupsSemestr1
                {
                    NameAcademiDisciplines="Філософія",
                    CountDisciplinesSemester=3,
                    Faculty="ПБ",
                    Curriculum=1,
                    AcademiсGroupsBud=3,
                    PracticalLessonBud=3,
                    LabLessonBud=2,
                    AcademicGroupsCon=1,
                    PracticalLessonCon=1,
                    LabLessonCon=3,
                    CodeGrup="ПО-92",
                    CountStudentsBud=80,
                    CountStudentsCon=9,
                    CountStreamsBud=1,
                    CountStreamsCon=2,
                    EmailTeacher="andriy@gmail.com"
                }
            };
            if (!content.Characteristic1Semestr.Any())
            {
                content.AddRange(characteristicGroups1list);
                content.SaveChanges();
            }

            List<CharacteristicGroupsSemestr2> characteristicGroups2list = new List<CharacteristicGroupsSemestr2>
            {
              new CharacteristicGroupsSemestr2
                {
                    NameAcademiDisciplines="Психологія",
                    CountDisciplinesSemester=3,
                    Faculty="РТФ",
                    Curriculum=3,
                    AcademiсGroupsBud=1,
                    PracticalLessonBud=1,
                    LabLessonBud=1,
                    AcademicGroupsCon=2,
                    PracticalLessonCon=3,
                    LabLessonCon=1,
                    CodeGrup="РІ-01",
                    CountStudentsBud=43,
                    CountStudentsCon=4,
                    CountStreamsBud=3,
                    CountStreamsCon=1,
                    EmailTeacher="teacher@gmail.com"
                },
                new CharacteristicGroupsSemestr2
                {
                    NameAcademiDisciplines="Англійська мова",
                    CountDisciplinesSemester=3,
                    Faculty="ПБ",
                    Curriculum=2,
                    AcademiсGroupsBud=2,
                    PracticalLessonBud=2,
                    LabLessonBud=2,
                    AcademicGroupsCon=3,
                    PracticalLessonCon=1,
                    LabLessonCon=1,
                    CodeGrup="ПО-92",
                   CountStudentsBud=50,
                    CountStudentsCon=2,
                    CountStreamsBud=3,
                    CountStreamsCon =3,
                   EmailTeacher="andriy@gmail.com"
                }
            };
            if (!content.Characteristic2Semestr.Any())
            {
                content.AddRange(characteristicGroups2list);
                content.SaveChanges();
            }

            List<LectureClassesTableSemestr1> lectureClassesTableSemestr1list = new List<LectureClassesTableSemestr1>
            {
                new LectureClassesTableSemestr1
                {
                    NameAcademiDisciplines = "Геометричне моделювання та комп'ютерна графіка",

                    LectureBudPl = 2,
                    LectureBudVuc = 4,
                    LectureConPl = 7,
                    LectureConVuc = 2,

                    PractBudPl = 5,
                    PractBudVuc = 44,
                    PractConPl = 20,
                    PractConVuc = 12,

                    LabBudPl = 10,
                    LabBudVuc = 5,
                    LabConPl = 8,
                    LabConVuc = 4,

                    IndBudPl = 12,
                    IndBudVuc = 30,
                    IndConPl = 15,
                    IndConVuc = 23,

                    EmailTeacher="teacher@gmail.com"
                },
                 new LectureClassesTableSemestr1
                {
                    NameAcademiDisciplines = "Математичні методи в психології",

                    LectureBudPl =3,
                    LectureBudVuc = 4,
                    LectureConPl = 1,
                    LectureConVuc = 2,

                    PractBudPl = 6,
                    PractBudVuc = 24,
                    PractConPl = 26,
                    PractConVuc = 32,

                    LabBudPl = 16,
                    LabBudVuc = 8,
                    LabConPl = 3,
                    LabConVuc = 9,

                    IndBudPl = 22,
                    IndBudVuc = 40,
                    IndConPl = 18,
                    IndConVuc = 13,

                    EmailTeacher = "andriy@gmail.com"
                }
            };
            if (!content.LectureClassesSemestr1.Any())
            {
                content.AddRange(lectureClassesTableSemestr1list);
                content.SaveChanges();
            }

            List<LectureClassesTableSemestr2> lectureClassesTableSemestr2list = new List<LectureClassesTableSemestr2>
            {
                new LectureClassesTableSemestr2
                {
                    NameAcademiDisciplines = "Математичні методи в психології",

                    LectureBudPl = 2,
                    LectureBudVuc = 4,
                    LectureConPl = 4,
                    LectureConVuc = 2,

                    PractBudPl = 4,
                    PractBudVuc = 24,
                    PractConPl = 24,
                    PractConVuc = 12,

                    LabBudPl = 17,
                    LabBudVuc = 7,
                    LabConPl = 9,
                    LabConVuc = 4,

                    IndBudPl = 10,
                    IndBudVuc = 40,
                    IndConPl = 15,
                    IndConVuc = 33,

                    EmailTeacher="teacher@gmail.com"
                },
                 new LectureClassesTableSemestr2
                {
                    NameAcademiDisciplines = "Психологія",

                    LectureBudPl = 30,
                    LectureBudVuc = 12,
                    LectureConPl = 25,
                    LectureConVuc = 24,

                    PractBudPl = 8,
                    PractBudVuc = 20,
                    PractConPl = 24,
                    PractConVuc = 12,

                    LabBudPl = 17,
                    LabBudVuc = 13,
                    LabConPl = 8,
                    LabConVuc = 10,

                    IndBudPl = 12,
                    IndBudVuc = 30,
                    IndConPl = 32,
                    IndConVuc = 26,

                    EmailTeacher = "andriy@gmail.com"
                }
            };
            if (!content.LectureClassesSemestr2.Any())
            {
                content.AddRange(lectureClassesTableSemestr2list);
                content.SaveChanges();
            }

            List<ControlMeasuresSemestr1> controlMeasuresSemestr1list = new List<ControlMeasuresSemestr1>
            {
                new ControlMeasuresSemestr1
                {
                    NameAcademiDisciplines = "Теорія прийняття рішень",
                    ExamBudPl = 4,
                    ExamBudVuc = 1,
                    ExamConPl = 5,
                    ExamConVuc = 4,
                    TestBudPl = 2,
                    TestBudVuc = 0,
                    TestConPl = 1,
                    TestConVuc = 4,
                    KRBudPl = 4,
                    KRBudVuc = 3,
                    KRConPl = 1,
                    KRConVuc = 5,
                    CursRobBudPl = 5,
                    CursRobBudVuc = 1,
                    CursRobConPl = 1,
                    CursRobConVuc = 1,
                    CursProectBudPl = 1,
                    CursProectBudVuc = 1,
                    CursProectConPl = 6,
                    CursProectConVuc = 6,
                    RGRBudPl = 5,
                    RGRBudVuc = 3,
                    RGRConPl = 4,
                    RGRConVuc = 4,
                    DKRBudPl = 4,
                    DKRBudVuc = 4,
                    DKRConPl = 4,
                    DKRConVuc = 5,
                    AbstractBudPl = 9,
                    AbstractBudVuc = 4,
                    AbstractConPl = 4,
                    AbstractConVuc = 8,
                    CosultationBudPl = 8,
                    CosultationBudVuc = 4,
                    CosultationConPl = 4,
                    CosultationConVuc = 6,
                    EmailTeacher="teacher@gmail.com"
                },

                new ControlMeasuresSemestr1
                {
                    NameAcademiDisciplines = "Системи штучного інтелекту",
                    ExamBudPl = 4,
                    ExamBudVuc = 1,
                    ExamConPl = 5,
                    ExamConVuc = 4,
                    TestBudPl = 2,
                    TestBudVuc = 0,
                    TestConPl = 1,
                    TestConVuc = 4,
                    KRBudPl = 4,
                    KRBudVuc = 3,
                    KRConPl = 1,
                    KRConVuc = 5,
                    CursRobBudPl = 5,
                    CursRobBudVuc = 1,
                    CursRobConPl = 1,
                    CursRobConVuc = 1,
                    CursProectBudPl = 1,
                    CursProectBudVuc = 1,
                    CursProectConPl = 6,
                    CursProectConVuc = 6,
                    RGRBudPl = 5,
                    RGRBudVuc = 3,
                    RGRConPl = 4,
                    RGRConVuc = 4,
                    DKRBudPl = 4,
                    DKRBudVuc = 4,
                    DKRConPl = 4,
                    DKRConVuc = 5,
                    AbstractBudPl = 9,
                    AbstractBudVuc = 4,
                    AbstractConPl = 4,
                    AbstractConVuc = 8,
                    CosultationBudPl = 8,
                    CosultationBudVuc = 4,
                    CosultationConPl = 4,
                    CosultationConVuc = 6,
                    EmailTeacher = "teacher@gmail.com"
                },
            };
            if (!content.ControlSemestr1.Any())
            {
                content.AddRange(controlMeasuresSemestr1list);
                content.SaveChanges();
            }

            List<ControlMeasuresSemestr2> controlMeasuresSemestr2list = new List<ControlMeasuresSemestr2>
            {
                new ControlMeasuresSemestr2
                {
                    NameAcademiDisciplines = "Програмування комп'ютерних мереж",
                    ExamBudPl = 5,
                    ExamBudVuc = 7,
                    ExamConPl = 5,
                    ExamConVuc = 7,

                    TestBudPl = 2,
                    TestBudVuc = 0,
                    TestConPl = 7,
                    TestConVuc = 4,

                    KRBudPl = 7,
                    KRBudVuc = 3,
                    KRConPl = 7,
                    KRConVuc = 5,

                    CursRobBudPl = 5,
                    CursRobBudVuc = 7,
                    CursRobConPl = 1,
                    CursRobConVuc = 7,

                    CursProectBudPl = 7,
                    CursProectBudVuc = 9,
                    CursProectConPl = 9,
                    CursProectConVuc = 9,

                    RGRBudPl = 9,
                    RGRBudVuc = 9,
                    RGRConPl = 9,
                    RGRConVuc = 4,

                    DKRBudPl = 10,
                    DKRBudVuc = 11,
                    DKRConPl = 6,
                    DKRConVuc = 5,

                    AbstractBudPl = 9,
                    AbstractBudVuc = 5,
                    AbstractConPl = 5,
                    AbstractConVuc = 5,

                    CosultationBudPl = 5,
                    CosultationBudVuc = 5,
                    CosultationConPl = 5,
                    CosultationConVuc = 5,

                    EmailTeacher="teacher@gmail.com"
                },

                new ControlMeasuresSemestr2
                {
                    NameAcademiDisciplines = "Інтелектуальний аналіз даних",
                    ExamBudPl = 5,
                    ExamBudVuc = 7,
                    ExamConPl = 5,
                    ExamConVuc = 7,
                    TestBudPl = 2,
                    TestBudVuc = 0,
                    TestConPl = 7,
                    TestConVuc = 4,
                    KRBudPl = 7,
                    KRBudVuc = 3,
                    KRConPl = 7,
                    KRConVuc = 5,
                    CursRobBudPl = 5,
                    CursRobBudVuc = 7,
                    CursRobConPl = 1,
                    CursRobConVuc = 7,
                    CursProectBudPl = 7,
                    CursProectBudVuc = 9,
                    CursProectConPl = 9,
                    CursProectConVuc = 9,
                    RGRBudPl = 9,
                    RGRBudVuc = 9,
                    RGRConPl = 9,
                    RGRConVuc = 4,
                    DKRBudPl = 10,
                    DKRBudVuc = 11,
                    DKRConPl = 6,
                    DKRConVuc = 5,
                    AbstractBudPl = 9,
                    AbstractBudVuc = 5,
                    AbstractConPl = 5,
                    AbstractConVuc = 5,
                    CosultationBudPl = 5,
                    CosultationBudVuc = 5,
                    CosultationConPl = 5,
                    CosultationConVuc = 5,
                    EmailTeacher = "teacher@gmail.com"
                },
            };
            if (!content.ControlSemestr2.Any())
            {
                content.AddRange(controlMeasuresSemestr2list);
                content.SaveChanges();
            }

            List<MethodicalWork> methodicalWorkList = new List<MethodicalWork>
            {
            new MethodicalWork
            {
                NameMethodicalWork="Методичка Грудзинського",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            },
            new MethodicalWork
            {
                NameMethodicalWork="Методичка Дзюби",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            }
            };

            if (!content.MethodicalWork.Any())
            {
                content.AddRange(methodicalWorkList);
                content.SaveChanges();
            }

            List<ScientificWork> scientificWorks = new List<ScientificWork>
            {
            new ScientificWork
            {
                NameScientificWork="Методичка Грудзинського",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            },
            new ScientificWork
            {
                NameScientificWork="Методичка Дзюби",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            }
            };

            if (!content.ScientificWork.Any())
            {
                content.AddRange(scientificWorks);
                content.SaveChanges();
            }

            List<OrganizationalWork> organizationalWorks = new List<OrganizationalWork>
            {
            new OrganizationalWork
            {
                NameOrganizationalWork="Методичка Грудзинського",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            },
            new OrganizationalWork
            {
                NameOrganizationalWork="Методичка Дзюби",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            }
            };

            if (!content.OrganizationalWork.Any())
            {
                content.AddRange(organizationalWorks);
                content.SaveChanges();
            }

            List<EducationalActivities> educationalActivities = new List<EducationalActivities>
            {
            new EducationalActivities
            {
                NameEducationalActivities="Методичка Грудзинського",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            },
            new EducationalActivities
            {
                NameEducationalActivities="Методичка Дзюби",
                 DateSuccess=DateTime.Now,
                 Correct=false,
                 EmailTeacher="teacher@gmail.com"
            }
            };

            if (!content.EducationalActivities.Any())
            {
                content.AddRange(educationalActivities);
                content.SaveChanges();
            }

            List<ChangesWorkPlan> changesWorks = new List<ChangesWorkPlan>
            {
            new ChangesWorkPlan
            {
                 NameChangesWorkPlan="Зменшення гонин",
                 CountReason=5,
                 ReasonChanges="Нестача часу",
                 EmailTeacher="teacher@gmail.com"
            },
            new ChangesWorkPlan
            {
                 NameChangesWorkPlan="Збільшення гонин",
                 CountReason=8,
                 ReasonChanges="Багато вільного часу",
                 EmailTeacher="teacher@gmail.com"
            }
            };

            if (!content.ChangesWorkPlan.Any())
            {
                content.AddRange(changesWorks);
                content.SaveChanges();
            }

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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
                ColumId = 34
            });

            if (!content.OtherTypesWorkSemestr2.Any())
            {
                //foreach (var item in otherTypesSemestr2)
                //{
                //    content.Add(item);
                //    content.SaveChanges();
                //}
                content.AddRange(otherTypesSemestr2);
                content.SaveChanges();
            }

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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
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
                EmailTeacher = "teacher@gmail.com",
                ColumId = 34
            });

            if (!content.OtherTypesWork.Any())
            {
                content.AddRange(otherTypes);
                content.SaveChanges();
            }

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
                EmailTeacher = "teacher@gmail.com"
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
                EmailTeacher = "teacher@gmail.com"
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
                EmailTeacher = "teacher@gmail.com"
            });

            if (!content.WorkloadSum.Any())
            {
                foreach (var item in workloadSums)
                {
                    content.Add(item);
                    content.SaveChanges();
                }
            }

            List<NameSubject> nameSubject = new List<NameSubject>
            {
                 new NameSubject
                 {
                     NameSubjects = "Теорія прийняття рішень"
                 },
                  new NameSubject
                 {
                     NameSubjects = "Вища математика"
                 },
                   new NameSubject
                 {
                     NameSubjects = "Геометричне моделювання та комп'ютерна графіка"
                 },
                    new NameSubject
                 {
                     NameSubjects = "Математичні методи в психології"
                 },
                     new NameSubject
                 {
                     NameSubjects = "Психологія"
                 },
                      new NameSubject
                 {
                     NameSubjects = "Філософія"
                 },
                       new NameSubject
                 {
                     NameSubjects = "Англійська мова"
                 },
                        new NameSubject
                 {
                     NameSubjects = "Системи штучного інтелекту"
                 },
                         new NameSubject
                 {
                     NameSubjects = "Програмування комп'ютерних мереж"
                 },
                          new NameSubject
                 {
                     NameSubjects = "Інтелектуальний аналіз даних"
                 }
            };

            if (!content.NameSubject.Any())
            {
                content.AddRange(nameSubject);
                content.SaveChanges();
            }

            List<LectureClassesTableNameSum> lectureClassesTableSums = new List<LectureClassesTableNameSum>
            {
                 new LectureClassesTableNameSum
                 {
                     NameColum = "Разом за II семестр"
                 },
                 new LectureClassesTableNameSum
                 {
                     NameColum = "Разом за I семестр"
                 },
                 new LectureClassesTableNameSum
                 {
                     NameColum = "Разом за рік"
                 }
            };

            if (!content.LectureClassesNameSums.Any())
            {
                content.AddRange(lectureClassesTableSums);
                content.SaveChanges();
            }

            UserNames userNames = new UserNames();
            userNames.DbUserId = 1;
            userNames.Name = "Тарас";
            userNames.LastName = "Шевченко";
            userNames.Status = false;

            if (!content.UserNames.Any())
            {
                content.Add(userNames);
                content.SaveChanges();
            }
        }
    }
}
