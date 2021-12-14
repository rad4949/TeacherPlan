using Plan.Data.Entities;
using Plan.Models;
using Plan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.intereces
{
    public interface IRepository
    {
        void createCharacteristicGroups1(CharacteristicGrupsViewModel characteristic1, string EmailTeacher);
        void createCharacteristicGroups2(CharacteristicGrupsViewModel characteristic2, string EmailTeacher);
        void createLectureClasses1(LectureClassesViewModel lectureClasses, string EmailTeacher);
        void createLectureClasses2(LectureClassesViewModel lectureClasses, string EmailTeacher);
        void createControlMeasures1(ControlMeasuresViewModels controlMeasures, string EmailTeacher);
        void createControlMeasures2(ControlMeasuresViewModels controlMeasures, string EmailTeacher);
        void createMethodicalWork(MethodicalWorkViewModel methodical, string EmailTeacher);
        void createScientificWork(ScientificWorkViewModel scientific, string EmailTeacher);
        void createOrganizationalWork(OrganizationalWorkViewModel organizational, string EmailTeacher);
        void createEducationalActivities(EducationalActivitiesViewModel educational, string EmailTeacher);
        void createChangesWorkPlan(ChangesWorkPlanViewModel changes, string EmailTeacher);
        public Task createOtherTypesWork1(string EmailTeacher);
        public Task createOtherTypesWork2(string EmailTeacher);
        public Task createWorkloadSum(string EmailTeacher);
        public Task createUserNames(UserNameModel userNameModel);

    }
}
