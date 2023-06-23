using AirplanesTickets.Commands;
using AirplanesTickets.DataAccess.Abstractions;
using AirplanesTickets.DataAccess.Concrete;
using AirplanesTickets.DataAccess.DbFirstModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesTickets.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        CityRepository cityRepo;
        AirplaneRepository airplaneRepo;
        FlightTypesRepository flightTypesRepo;
        ScheduleRepository scheduleRepository;
        TicketRepository ticketRepository;

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; OnPropertyChanged(); }
        }

        public RelayCommand SelectedCityCommand { get; set; }
        public RelayCommand SelectedAirplaneCommand { get; set; }
        public RelayCommand PurchaseCommand { get; set; }

        private ObservableCollection<City> allCities;

        public ObservableCollection<City> AllCities
        {
            get { return allCities; }
            set { allCities = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Airplane> allAirplanes;

        public ObservableCollection<Airplane> AllAirplanes
        {
            get { return allAirplanes; }
            set { allAirplanes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Schedule> allSchedules;

        public ObservableCollection<Schedule> AllSchedules
        {
            get { return allSchedules; }
            set { allSchedules = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FlightType> allFlightTypes;

        public ObservableCollection<FlightType> AllFlightTypes
        {
            get { return allFlightTypes; }
            set { allFlightTypes = value; OnPropertyChanged(); }
        }

        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set { selectedCity = value; OnPropertyChanged(); }
        }

        private Airplane selectedAirplane;

        public Airplane SelectedAirplane
        {
            get { return selectedAirplane; }
            set { selectedAirplane = value; OnPropertyChanged(); }
        }

        private Schedule selectedSchedule;

        public Schedule SelectedSchedule
        {
            get { return selectedSchedule; }
            set { selectedSchedule = value; OnPropertyChanged(); }
        }

        private FlightType selectedFlightType;

        public FlightType SelectedFlightType
        {
            get { return selectedFlightType; }
            set { selectedFlightType = value; OnPropertyChanged(); }
        }

        private string pilotName;

        public string PilotName
        {
            get { return pilotName; }
            set { pilotName = value; OnPropertyChanged(); }
        }

        private string pilotSurname;

        public string PilotSurname
        {
            get { return pilotSurname; }
            set { pilotSurname = value; OnPropertyChanged(); }
        }

        private string ticketCity;

        public string TicketCity
        {
            get { return ticketCity; }
            set { ticketCity = value; OnPropertyChanged(); }
        }

        private string ticketAirplane;

        public string TicketAirplane
        {
            get { return ticketAirplane; }
            set { ticketAirplane = value; OnPropertyChanged(); }
        }

        private string ticketDate;

        public string TicketDate
        {
            get { return ticketDate; }
            set { ticketDate = value; OnPropertyChanged(); }
        }

        private string ticketFlightType;

        public string TicketFlightType
        {
            get { return ticketFlightType; }
            set { ticketFlightType = value; OnPropertyChanged(); }
        }

        private string ticketPName;

        public string TicketPName
        {
            get { return ticketPName; }
            set { ticketPName = value; OnPropertyChanged(); }
        }

        private string ticketPSurname;

        public string TicketPSurname
        {
            get { return ticketPSurname; }
            set { ticketPSurname = value; OnPropertyChanged(); }
        }


        public MainViewModel()
        {
            scheduleRepository = new ScheduleRepository();
            cityRepo = new CityRepository();
            airplaneRepo = new AirplaneRepository();
            flightTypesRepo = new FlightTypesRepository();
            ticketRepository = new TicketRepository();

            allCities = cityRepo.GetAll();
            allAirplanes = airplaneRepo.GetAll();
            allFlightTypes = flightTypesRepo.GetAll();

            SelectedCityCommand = new RelayCommand(async (obj) =>
            {
                var cityId = selectedCity.Id;
                AllSchedules = await scheduleRepository.CityGetAll(cityId);
                IsSelected = true;
            });

            SelectedAirplaneCommand = new RelayCommand((obj) =>
            {
                PilotName = selectedAirplane.Pilot.Name;
                PilotSurname = selectedAirplane.Pilot.Surname;
            });

            PurchaseCommand = new RelayCommand((obj) =>
            {
                var ticket = new Ticket
                {
                    CityId = selectedCity.Id,
                    AirplaneId = selectedAirplane.Id,
                    ScheduleId = selectedSchedule.Id,
                    FlightTypeId=selectedFlightType.Id,
                };

                ticketRepository.AddData(ticket);

                TicketCity = selectedCity.Name;
                TicketAirplane = selectedAirplane.Model;
                TicketDate = selectedSchedule.StartDate.ToString();
                TicketFlightType = selectedFlightType.Type;
                TicketPName = PilotName;
                TicketPSurname = PilotSurname;
            });

        }



    }

}
