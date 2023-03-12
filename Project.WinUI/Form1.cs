using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        BookingRepository _bookingRepository;
        RoomRepository _roomRepository;
        RoomTypeRepository _roomTypeRepository;
        RoomBookingRepository _roomBookingRepository;
        OrderRepository _orderRepository;
        HouseKeepingRepository _houseKeepingRepository;
        CustomerRepository _customerRepository;
        List<Room> rooms;
        List<Customer> customers;
        List<Booking> bookings;
        List<Order> orders;
        Room _selectedRoom;
        Customer _selectedCustomer;
        Booking bk;
        RoomBooking rbooking;
        Booking _selectedBooking;
        Order _selectedOrder;
        List<RoomBooking> roomBookings;
        RoomBooking _selectedRoomBooking;
        decimal totalPrice;



        public Form1()
        {
            _bookingRepository = new BookingRepository();
            _roomRepository = new RoomRepository();
            _roomBookingRepository = new RoomBookingRepository();
            _orderRepository = new OrderRepository();
            _customerRepository = new CustomerRepository();
            _houseKeepingRepository = new HouseKeepingRepository();
            _roomTypeRepository = new RoomTypeRepository();
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            customers = _customerRepository.GetActives();
            foreach (Customer item in customers)
            {
                lstCustomers.Items.Add(item);
            }
            bookings = _bookingRepository.GetActives();
            foreach (Booking item in bookings)
            {
                lstBookings.Items.Add(item);
            }
            rooms = _roomRepository.GetAll();
            foreach (Room item in rooms)
            {
                lstRooms.Items.Add(item);
            }
            orders = _orderRepository.GetAll();
            foreach (Order item in orders)
            {
                cmbOrders.Items.Add(item);
            }
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckOut.MinDate = DateTime.Now;


            tmrControl.Start();



            //foreach (Booking item in bookings)
            //{
            //    if (item.CheckOut.Date <= DateTime.Now)
            //    {

            //    }
            //}

        }

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtPhoneNo.Text != "" && txtEmail.Text != "" && txtTc.Text != "")
            {
                Customer cus = new Customer()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Tc = txtTc.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNo.Text,
                };
                _customerRepository.Add(cus);
                lstCustomers.Items.Add(cus);
            }
            else
            {
                MessageBox.Show("Müşteri bilgilerinin tamamını girdiğinizden emin olunuz.");
            }

        }

        private void btnAddBooking_Click(object sender, System.EventArgs e)
        {
            if (lstRooms.SelectedIndex > -1 && dtpCheckIn.Value <= dtpCheckOut.Value && nmrCount.Value > 0)
            {
                bk = new Booking()
                {
                    CheckIn = dtpCheckIn.Value,
                    CheckOut = dtpCheckOut.Value,
                    PersonCount = Convert.ToByte(nmrCount.Value),
                    CustomerID = _selectedCustomer.ID,
                    Price = _selectedRoom.RoomPrice
                };
                rbooking = new RoomBooking()
                {
                    BookingID = bk.ID,
                    RoomID = _selectedRoom.ID,
                };
                _selectedRoom.RoomStatus = ENTITIES.Enums.RoomStatus.Full;
                _roomBookingRepository.Add(rbooking);
                _bookingRepository.Add(bk);
                lstBookings.Items.Add(bk);
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz.");
            }

        }

        private void lstRooms_Click(object sender, System.EventArgs e)
        {
            if (lstRooms.SelectedIndex > -1)
            {
                _selectedRoom = lstRooms.SelectedItem as Room;
            }
        }
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex > -1 && _selectedCustomer.Bookings != null)
            {                
                lstBookings.Items.Clear();
                foreach (Booking item in _selectedCustomer.Bookings)
                {
                    lstBookings.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Bu müşterinin bir rezervasyonu olmadığından görüntüleme yapılamıyor.");
            }
        }
        private void lstCustomers_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex > -1)
            {
                _selectedCustomer = lstCustomers.SelectedItem as Customer;
            }
        }


        private void btnActiveBookings_Click(object sender, EventArgs e)
        {
            lstBookings.Items.Clear();
            bookings = _bookingRepository.GetActives();
            foreach (Booking item in bookings)
            {
                lstBookings.Items.Add(item);
            }
        }

        private void lstBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBookings.SelectedIndex > -1)
            {
                lstOrders.Items.Clear();
                foreach (Order item in _selectedBooking.Orders)
                {
                    lstOrders.Items.Add(item);
                }
            }
        }

        private void lstBookings_Click(object sender, EventArgs e)
        {
            if (lstBookings.SelectedIndex > -1)
            {
                _selectedBooking = lstBookings.SelectedItem as Booking;
            }
        }

        private void btnPassiveCustomers_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();
            customers = _customerRepository.GetPassives();
            foreach (Customer item in customers)
            {
                lstCustomers.Items.Add(item);
            }
        }

        private void btnPassiveRezs_Click(object sender, EventArgs e)
        {
            lstBookings.Items.Clear();
            bookings = _bookingRepository.GetPassives();
            foreach (Booking item in bookings)
            {
                lstBookings.Items.Add(item);
            }
        }

        private void btnActiveCustomers_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();
            customers = _customerRepository.GetActives();
            foreach (Customer item in customers)
            {
                lstCustomers.Items.Add(item);
            }
        }

        private void btnActiveBookings_Click_1(object sender, EventArgs e)
        {
            lstBookings.Items.Clear();
            bookings = _bookingRepository.GetActives();
            foreach (Booking item in bookings)
            {
                lstBookings.Items.Add(item);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex > -1 && lstBookings.SelectedIndex > -1)
            {
                _selectedOrder = cmbOrders.SelectedItem as Order;
                _selectedBooking.Orders.Add(_selectedOrder);
                _selectedBooking.Price += _selectedOrder.OrderPrice;
                _bookingRepository.Update(_selectedBooking);
            }
        }

        private void btnEmptyRooms_Click(object sender, EventArgs e)
        {
            lstRooms.Items.Clear();
            rooms = _roomRepository.Where(x => x.CleanStatus == true && x.RoomStatus == ENTITIES.Enums.RoomStatus.Empty).ToList();
            foreach (Room item in rooms)
            {
                lstRooms.Items.Add(item);
            }
        }

        private void btnFullRooms_Click(object sender, EventArgs e)
        {
            lstRooms.Items.Clear();
            rooms = _roomRepository.Where(x => x.RoomStatus == ENTITIES.Enums.RoomStatus.Full || x.CleanStatus == false).ToList();
            foreach (Room item in rooms)
            {
                lstRooms.Items.Add(item);
            }
        }

        private void tmrControl_Tick(object sender, EventArgs e)
        {
            bookings = _bookingRepository.GetAll();
            roomBookings = _roomBookingRepository.GetAll();
            rooms = _roomRepository.GetAll();
            foreach (Booking item in bookings)
            {
                foreach (RoomBooking rb in item.RoomBookings)
                {
                    if (item.CheckOut <= DateTime.Now)
                    {
                        rb.Room.RoomStatus = ENTITIES.Enums.RoomStatus.Empty;
                        rb.Room.CleanStatus = false;
                        _roomRepository.UpdateRange(rooms);
                    }
                }

            }
        }

        private void btnCleanRoom_Click(object sender, EventArgs e)
        {

            if (lstRooms.SelectedIndex > -1)
            {
                _selectedRoom.CleanStatus = true;
                _roomRepository.Update(_selectedRoom);
            }
            else
            {
                MessageBox.Show("Bir oda seçiniz.");
            }
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            if (lstBookings.SelectedIndex > -1)
            {
                foreach (RoomBooking item in _selectedBooking.RoomBookings)
                {
                    _roomBookingRepository.GetAll();

                    totalPrice += item.Room.RoomPrice;
                }
                foreach (Order item in _selectedBooking.Orders)
                {
                    _orderRepository.GetAll();

                    totalPrice += item.OrderPrice;
                }
            }
        }


    }
}
